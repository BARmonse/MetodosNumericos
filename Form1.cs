using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodosNumericos
{
    public partial class Form1 : Form
    {
        double inferiorA;
        double superiorA;
        double b;
        double c;
        RungeKutta metodoRungeKutta;
        Euler metodoEuler;
        DataTable tabla;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void tomarDatos()
        {
            inferiorA = double.Parse(limInferiorA.Text);
            superiorA = double.Parse(limSuperiorA.Text);
            b = double.Parse(constanteB.Text);
            c = double.Parse(constanteC.Text);
        }
        private void btnSimular_Click(object sender, EventArgs e)
        {
            tomarDatos();
            if (rbEuler.Checked)
            {
                metodoEuler = new Euler(this);
                metodoEuler.simular(inferiorA, superiorA, b, c);

            }
            if (rbRungeKutta.Checked)
            {
                metodoRungeKutta = new RungeKutta(this);
                metodoRungeKutta.simular(inferiorA, superiorA, b, c);
            }
        }

        public void mostrarResultados(DataTable resultados)
        {
            grdResultados.Columns.Clear();
            this.grdResultados.DataSource = resultados;
        }

        private void btnGraficarXFuncionTiempo_Click(object sender, EventArgs e)
        {
            if (rbEuler.Checked)
            {
                metodoEuler.graficarXFuncionTiempo();
            }
            if (rbRungeKutta.Checked)
            {
                metodoRungeKutta.graficarXFuncionTiempo();
            }
        }

        private void btnGraficarDerivadaFuncionTiempo_Click(object sender, EventArgs e)
        {
            if (rbEuler.Checked)
            {
                metodoEuler.graficarDerivadaFuncionTiempo();
            }
            if (rbRungeKutta.Checked)
            {
                metodoRungeKutta.graficarDerivadaFuncionTiempo();
            }
        }

        private void btnGraficarDerivadaSegundaFuncionTiempo_Click(object sender, EventArgs e)
        {
            if (rbEuler.Checked)
            {
                metodoEuler.graficarDerivadaSegundaFuncionTiempo();
            }
        }

        private void btnGraficarDerivadaSegundaFuncionX_Click(object sender, EventArgs e)
        {
            if (rbEuler.Checked)
            {
                metodoEuler.graficarDerivadaSegundaFuncionX();
            }
            if (rbRungeKutta.Checked)
            {
                metodoRungeKutta.graficarDerivadaSegundaFuncionX();
            }
        }

        private void btnGraficarDerivadaFuncionX_Click(object sender, EventArgs e)
        {
            if (rbEuler.Checked)
            {
                metodoEuler.graficarDerivadaFuncionX();
            }
        }

        private void btnGraficarDerivadaSegundaFuncionDerivada_Click(object sender, EventArgs e)
        {
            if (rbEuler.Checked)
            {
                metodoEuler.graficarDerivadaSegundaFuncionDerivada();
            }
        }
    }
}
