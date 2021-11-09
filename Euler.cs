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
    class Euler
    {
        private Form1 pantalla;
        private DataTable tabla;
        private Truncador truncador;
        private Random aleatorio;
        private double limInferiorA;
        private double limSuperiorA;
        private double b;
        private double c;
        private double a;
        private double contador;
        private double[] lineaAnterior;
        private double[] lineaActual;
        private double tiempo;
        private double x1;
        private double x2;
        private double derivadaX2;
        private double h;
        private double iteracion;

        private List<double> valoresX1;
        private List<double> valoresX2;
        private List<double> valoresDerivadaX2;
        private List<double> tiempos;

        public Euler(Form1 pantalla)
        {
            this.truncador = new Truncador(4);
            this.pantalla = pantalla;
            this.lineaActual = new double[4];
            this.lineaAnterior = new double[4];
            this.tiempo = 0;
            this.x1 = 0;
            this.x2 = 0;
            this.h = 0.05;
            this.iteracion = 0;
            this.contador = 0;
            this.aleatorio = new Random();
            this.valoresX1 = new List<double>();
            this.valoresX2 = new List<double>();
            this.valoresDerivadaX2 = new List<double>();
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
            DataRow row;
            while (true)
            {
                tiempo += h;
                x1 +=  h * x2;
                x2 +=  + h * derivadaX2;

                if (iteracion == 0)
                {
                    x1 = 0;
                    x2 = 0;
                    tiempo = 0;
                }

                derivadaX2 = (-b) * x1 - a * x2 + Math.Exp(-c * tiempo) ;

                if (x2 < 0 && lineaAnterior[2] > 0)
                {
                    contador++;
                }

                lineaActual[0] = tiempo;
                lineaActual[1] = x1;
                lineaActual[2] = x2;
                lineaActual[3] = derivadaX2;

                iteracion++;

                valoresX1.Add(x1);
                valoresX2.Add(x2);
                valoresDerivadaX2.Add(derivadaX2);
                tiempos.Add(tiempo);

                row = tabla.NewRow();
                for (int j = 0; j < lineaActual.Length; j++)
                {
                    row[j] = truncador.truncar(lineaActual[j]);
                }
                tabla.Rows.Add(row);

                if (contador == 2)
                {
                   MessageBox.Show("Segundo pico en t= ", truncador.truncar(tiempos[tiempos.Count - 2]).ToString());
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
            tabla.Columns.Add("x2");
            tabla.Columns.Add("x2'");
        }
        public void graficarXFuncionTiempo()
        {
            Graficador graficador = new Graficador();
            graficador.puntosAbscisa = this.tiempos.ToArray();
            graficador.puntosOrdenada = this.valoresX1.ToArray();
            graficador.xlabel = "Tiempo(s)";
            graficador.ylabel = "X1";
            graficador.Show();
        }

        public void graficarDerivadaFuncionTiempo()
        {
            Graficador graficador = new Graficador();
            graficador.puntosAbscisa = this.tiempos.ToArray();
            graficador.puntosOrdenada = this.valoresX2.ToArray();
            graficador.xlabel = "Tiempo(s)";
            graficador.ylabel = "X2";
            graficador.Show();
        }

        public void graficarDerivadaSegundaFuncionTiempo()
        {
            Graficador graficador = new Graficador();
            graficador.puntosAbscisa = this.tiempos.ToArray();
            graficador.puntosOrdenada = this.valoresDerivadaX2.ToArray();
            graficador.xlabel = "Tiempo(s)";
            graficador.ylabel = "X2'";
            graficador.Show();
        }
        public void graficarDerivadaSegundaFuncionX()
        {
            Graficador graficador = new Graficador();
            graficador.puntosAbscisa = this.valoresX1.ToArray();
            graficador.puntosOrdenada = this.valoresDerivadaX2.ToArray();
            graficador.xlabel = "X1";
            graficador.ylabel = "X2'";
            graficador.Show();
        }
        public void graficarDerivadaFuncionX()
        {
            Graficador graficador = new Graficador();
            graficador.puntosAbscisa = this.valoresX1.ToArray();
            graficador.puntosOrdenada = this.valoresX2.ToArray();
            graficador.xlabel = "X1";
            graficador.ylabel = "X2";
            graficador.Show();
        }
        public void graficarDerivadaSegundaFuncionDerivada()
        {
            Graficador graficador = new Graficador();
            graficador.puntosAbscisa = this.valoresX2.ToArray();
            graficador.puntosOrdenada = this.valoresDerivadaX2.ToArray();
            graficador.xlabel = "X2";
            graficador.ylabel = "X2'";
            graficador.Show();
        }
    }
}
