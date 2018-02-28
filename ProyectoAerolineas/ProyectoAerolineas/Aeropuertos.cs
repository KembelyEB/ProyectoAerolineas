using AerolineasENTIDADES;
using AerolineasNEGOCIO;
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
    public partial class Aeropuertos : MetroFramework.Forms.MetroForm
    {
        public Aeropuertos()
        {
            InitializeComponent();
        }

        private void Aeropuerto_Load(object sender, EventArgs e)
        {
            InsertarAeropuerto();
        }

        private void Registrar_Click(object sender, EventArgs e)
        {

        }

        private void InsertarAeropuerto()
        {
            var aeropuerto = new Aeropuerto
            {
                Nombre = txtNombre.Text,
                Localidad= txtLocalidad.Text,
                Iata = txtIata.Text
            };

            var AeropuertoBo = new AeropuertoBO();

            try
            {
                AeropuertoBo.RegistrarAeropuerto(aeropuerto);
                MonstrarMensaje("Aeropuerto creado satisfactoriamente");
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
