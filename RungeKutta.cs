using MetodosNumericos.Soporte;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodosNumericos
{
    class RungeKutta
    {
        private Form1 pantalla;
        private DataTable tabla;
        private Truncador truncador;
        private Random aleatorio;
        private double tiempo;
        private double x1;
        private double k1;
        private double k2;
        private double k3;
        private double k4;
        private double x2;
        private double l1;
        private double l2;
        private double l3;
        private double l4;

        private double limInferiorA;
        private double limSuperiorA;
        private double b;
        private double c;
        private double a;
        private double h;
        private double iteracion;
        private double contador;

        private double[] lineaActual;
        private double[] lineaAnterior;

        private List<double> valoresX1;
        private List<double> valoresX2;
        private List<double> tiempos;

        public RungeKutta(Form1 pantalla)
        {
            this.truncador = new Truncador(4);
            this.pantalla = pantalla;
            this.tiempo = 0;
            this.x1 = 0;
            this.x2 = 0;
            this.h = 0.05;
            this.iteracion = 0;
            this.aleatorio = new Random();
            this.lineaActual = new double[11];
            this.lineaAnterior = new double[11];
            this.valoresX1 = new List<double>();
            this.valoresX2 = new List<double>();
            this.tiempos = new List<double>();
        }

        public void simular(double limInferiorA, double limSuperiorA, double b,double c)
        {
            this.limInferiorA = limInferiorA;
            this.limSuperiorA = limSuperiorA;
            this.b = b;
            this.c = c;
            a = limInferiorA + (limSuperiorA - limInferiorA) * aleatorio.NextDouble();
            crearTabla();
            procesar(a, b, c, tabla);
            pantalla.mostrarResultados(tabla);
        }

        private void procesar(double a,double b,double c,DataTable tabla)
        {
            contador = 0;
            DataRow row;

            while (true)
            {
                if (iteracion == 0)
                {
                    tiempo = 0;
                    x1 = 0;
                    x2 = 0;
                }
                if (iteracion > 0)
                {
                    tiempo += h;
                    x1 += (k1 + 2 * k2 + 2 * k3 + k4) / 6;
                    x2 += (l1 + 2 * l2 + 2 * l3 + l4) / 6;
                }
                k1 = h * x2;
                l1 = h * (Math.Exp(-c * tiempo) - a * x2 - b * x1);
                k2 = h * (x2 + 0.5 * l1);
                l2 = h * (Math.Exp(-c * (tiempo+0.5*h)) - a * (x2+0.5*l1) - b * (x1+0.5*k1));
                k3 = h * (x2 + 0.5 * l2);
                l3 = h * (Math.Exp(-c * (tiempo + 0.5 * h)) - a * (x2 + 0.5 * l2) - b * (x1 + 0.5 * k2));
                k4 = h * (x2 + l3);
                l4 = h * (Math.Exp(-c * (tiempo + h)) - a * (x2 +  l3) - b * (x1 + k3));

                if (x2 < 0 && lineaAnterior[6] > 0)
                {
                    contador++;
                }

                lineaActual[0] = tiempo;
                lineaActual[1] = x1;
                lineaActual[2] = k1;
                lineaActual[3] = k2;
                lineaActual[4] = k3;
                lineaActual[5] = k4;
                lineaActual[6] = x2;
                lineaActual[7] = l1;
                lineaActual[8] = l2;
                lineaActual[9] = l3;
                lineaActual[10] = l4;

                iteracion++;

                valoresX1.Add(x1);
                valoresX2.Add(x2);
                tiempos.Add(tiempo);

                row = tabla.NewRow();
                for (int j = 0; j < lineaActual.Length; j++)
                {
                    row[j] = truncador.truncar(lineaActual[j]);
                }
                tabla.Rows.Add(row);

                if (contador == 2)
                {
                    MessageBox.Show("Segundo pico en t= ", truncador.truncar(tiempo).ToString());
                    break;
                }

                lineaAnterior = lineaActual;
            }
        }

        private void crearTabla()
        {
            tabla = new DataTable();
            tabla.Clear();
            tabla.Columns.Add("t");
            tabla.Columns.Add("x1");
            tabla.Columns.Add("k1");
            tabla.Columns.Add("k2");
            tabla.Columns.Add("k3");
            tabla.Columns.Add("k4");
            tabla.Columns.Add("x2");
            tabla.Columns.Add("l1");
            tabla.Columns.Add("l2");
            tabla.Columns.Add("l3");
            tabla.Columns.Add("l4");
        }
        public void graficarXFuncionTiempo()
        {
            Graficador graficador = new Graficador();
            graficador.puntosAbscisa = this.tiempos.ToArray();
            graficador.puntosOrdenada = this.valoresX1.ToArray();
            graficador.Show();
        }
        public void graficarDerivadaFuncionTiempo()
        {
            Graficador graficador = new Graficador();
            graficador.puntosAbscisa = this.tiempos.ToArray();
            graficador.puntosOrdenada = this.valoresX2.ToArray();
            graficador.Show();
        }
        public void graficarDerivadaSegundaFuncionX()
        {
            Graficador graficador = new Graficador();
            graficador.puntosAbscisa = this.valoresX1.ToArray();
            graficador.puntosOrdenada = this.valoresX2.ToArray();
            graficador.Show();
        }
    }
}
