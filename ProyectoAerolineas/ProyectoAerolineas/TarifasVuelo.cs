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
    public partial class TarifasVuelo : MetroFramework.Forms.MetroForm
    {
        public TarifasVuelo()
        {
            InitializeComponent();
        }

        private void TarifaVuelo_Load(object sender, EventArgs e)
        {

        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            InsertarTarifaVuelo();
        }

        private void InsertarTarifaVuelo()
        {
            var tVuelo = new TarifaVuelo
            {

                Ruta = txtRuta.Text,
                Precio = txtPrecio.Text,



            };

            var taVueloBo = new TarifaVueloBO();

            try
            {
                taVueloBo.RegistrarLugar(tVuelo);
                MonstrarMensaje("Tarifa hotel creado satisfactoriamente");
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
