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
    public partial class Rutass : MetroFramework.Forms.MetroForm
    {
        public Rutass()
        {
            InitializeComponent();
        }

        private void Ruta_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertarRuta();
        }

        private void InsertarRuta()
        {
            var ruta = new Ruta
            {
                Duracion = txtDuracion.Text,
                Pais_Origen = txtPaisOrigen.Text,
                Pais_Destino = txtPaisDestino.Text,


            };

            var rutaBo = new RutaBO();

            try
            {
                rutaBo.RegistrarRuta(ruta);
                MonstrarMensaje("Ruta creado satisfactoriamente");
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void ModificarrRuta()
        {
            var ruta = new Ruta
            {
                Duracion = txtDuracion.Text,
                Pais_Origen = txtPaisOrigen.Text,
                Pais_Destino = txtPaisDestino.Text,


            };

            var rutaBo = new RutaBO();

            try
            {
                rutaBo.Modificar(ruta);
                MonstrarMensaje("Ruta modificada satisfactoriamente");
            }
            catch (Exception e)
            {
                MonstrarError(e.Message);
            }
        }
        private void EliminarRuta()
        {
            var ruta = new Ruta
            {
                Duracion = txtDuracion.Text,
                Pais_Origen = txtPaisOrigen.Text,
                Pais_Destino = txtPaisDestino.Text,


            };

            var rutaBo = new RutaBO();

            try
            {
                if (!txtDuracion.Text.Equals(""))
                {
                    rutaBo.Eliminaro(txtDuracion.Text.Trim());
                    MonstrarMensaje("Ruta eliminado satisfactoriamente");
                }
            }
            catch (Exception e)
            {
                MonstrarError(e.Message);
            }
        }
    }
}
