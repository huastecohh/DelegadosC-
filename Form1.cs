using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DelegadosC_
{
    public partial class Form1 : Form
    {
        public delegate double OperacionMatematica(double x1, double y1, double x2, double y2);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void angulo1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double x1 = double.Parse(txtx1.Text);
            double y1 = double.Parse(txty1.Text);
            double x2 = double.Parse(txtx2.Text);
            double y2 = double.Parse(txty2.Text);
            4
            double pendiente = CalcularPendiente(x1, y1, x2, y2);
            double angulo = CalcularAngulo(pendiente);
            lblresultado.Text = $"Ángulo: {angulo} grados";

            DibujarPlano(x1, y1, x2, y2);
        }

        private void distanciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double x1 = double.Parse(txtx1.Text);
            double y1 = double.Parse(txty1.Text);
            double x2 = double.Parse(txtx2.Text);
            double y2 = double.Parse(txty2.Text);

            OperacionMatematica operacion = CalcularDistancia;
            double resultado = operacion(x1, y1, x2, y2);
            lblresultado.Text = $"Distancia: {resultado}";

            DibujarPlano(x1, y1, x2, y2);
        }
        public double CalcularDistancia(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        public double CalcularPendiente(double x1, double y1, double x2, double y2)
        {
            return (y2 - y1) / (x2 - x1);
        }

        public double CalcularAngulo(double pendiente)
        {
            return Math.Atan(pendiente) * (180 / Math.PI);
        }

        private void DibujarPlano(double x1, double y1, double x2, double y2)
        {
            chart1.Series.Clear();
            var serie = new Series("Línea");
            serie.ChartType = SeriesChartType.Line;
            serie.Points.AddXY(x1, y1);
            serie.Points.AddXY(x2, y2);
            chart1.Series.Add(serie);
        }

        private void pendienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            double x1 = double.Parse(txtx1.Text);
            double y1 = double.Parse(txty1.Text);
            double x2 = double.Parse(txtx2.Text);
            double y2 = double.Parse(txty2.Text);

            OperacionMatematica operacion = CalcularPendiente;
            double resultado = operacion(x1, y1, x2, y2);
            lblresultado.Text = $"Pendiente: {resultado}";

            DibujarPlano(x1, y1, x2, y2);
        }

        private void florAmarillaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
