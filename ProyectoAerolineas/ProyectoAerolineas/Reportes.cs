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

namespace ProyectoAerolineas
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {

        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

            //los vectores con los datos
            string[] series = { "", "", "" };
            int[] puntos = { 0, 0, 0 };

            //cambiar color
            chart1.Palette = ChartColorPalette.Chocolate;

            chart1.Titles.Add("Hoteles Reservados");

            for (int i = 0; i < series.Length; i++)
            {
                //titulos
                Series serie = chart1.Series.Add(series[i]);

                //cantidades
                serie.Label = puntos[i].ToString();
                serie.Points.Add(puntos[i]);
            }

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            //los vectores con los datos
            string[] series = { "", "", "" };
            int[] puntos = { 0, 0, 0 };

            //cambiar color
            chart1.Palette = ChartColorPalette.Chocolate;

            chart1.Titles.Add("Personas Reservadas");

            for (int i = 0; i < series.Length; i++)
            {
                //titulos
                Series serie = chart1.Series.Add(series[i]);

                //cantidades
                serie.Label = puntos[i].ToString();
                serie.Points.Add(puntos[i]);
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            //los vectores con los datos
            string[] series = { "", "", "" };
            int[] puntos = { 0, 0, 0 };

            //cambiar color
            chart1.Palette = ChartColorPalette.Chocolate;

            chart1.Titles.Add("Visitas por país");

            for (int i = 0; i < series.Length; i++)
            {
                //titulos
                Series serie = chart1.Series.Add(series[i]);

                //cantidades
                serie.Label = puntos[i].ToString();
                serie.Points.Add(puntos[i]);
            }
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
            //los vectores con los datos
            string[] series = { "", "", "" };
            int[] puntos = { 0, 0, 0 };

            //cambiar color
            chart1.Palette = ChartColorPalette.Chocolate;

            chart1.Titles.Add("Adultos que han viajado");

            for (int i = 0; i < series.Length; i++)
            {
                //titulos
                Series serie = chart1.Series.Add(series[i]);

                //cantidades
                serie.Label = puntos[i].ToString();
                serie.Points.Add(puntos[i]);

            }
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {
            //los vectores con los datos
            string[] series = { "", "", "" };
            int[] puntos = { 0, 0, 0 };

            //cambiar color
            chart1.Palette = ChartColorPalette.Chocolate;

            chart1.Titles.Add("Niños que han viajado");

            for (int i = 0; i < series.Length; i++)
            {
                //titulos
                Series serie = chart1.Series.Add(series[i]);

                //cantidades
                serie.Label = puntos[i].ToString();
                serie.Points.Add(puntos[i]);
            }
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {
            //los vectores con los datos
            string[] series = { "", "", "" };
            int[] puntos = { 0, 0, 0 };

            //cambiar color
            chart1.Palette = ChartColorPalette.Chocolate;

            chart1.Titles.Add("Vehiculos más rentados");

            for (int i = 0; i < series.Length; i++)
            {
                //titulos
                Series serie = chart1.Series.Add(series[i]);

                //cantidades
                serie.Label = puntos[i].ToString();
                serie.Points.Add(puntos[i]);
            }
        }
    }
}
