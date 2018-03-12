using AerolineasDATOS;
using AerolineasENTIDADES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAerolineas
{
    public partial class BuscaVuelo : MetroFramework.Forms.MetroForm
    {
        public BuscaVuelo()
        {
            InitializeComponent();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void BuscaVuelo_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void InsertarReservaVuelo()
        {
            var reservaVuelo = new ReservaVuelos
            {
                Origen = txtOrigen.Text,
                Destino = txtDestino.Text,
                salida  = dtIDA.Text
                llegada = dtLLEGADA.Text,
                Pasajeros = txtPasajeros.Text,
                id_Ruta = dataGridView1.CurrentsRows.cells[0].Value.toString()

        };

            var  rVuelo = new ReservaVuelo();

            try
            {
                rVuelo.InsertarDatos(reservaVuelo);
                MonstrarMensaje("Reserva Vuelo  creado satisfactoriamente");
            }
            catch (Exception e)
            {
                MonstrarError(e.Message);
            }
        }

        private void MonstrarMensaje(string mensaje)
        {
            lblMensaje.Text = mensaje;
            lblMensaje.ForeColor = Color.Blue;
            lblMensaje.Visible = true;
        }

        private void MonstrarError(string mensaje)
        {
            lblMensaje.Text = mensaje;
            lblMensaje.ForeColor = Color.DarkRed;
            lblMensaje.Visible = true;
        }

    }
}
