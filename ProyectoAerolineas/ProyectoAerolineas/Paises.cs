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
    public partial class Paises : MetroFramework.Forms.MetroForm
    {
        public Paises()
        {
            InitializeComponent();
        }

        private void Pais_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertarPais();
        }

        private void InsertarPais()
        {
            var pais  = new Pais
            {
                Nombre = txtNombre.Text,


            };

            var paisBo = new PaisesBO();

            try
            {
                paisBo.RegistrarPais(pais);
                MonstrarMensaje("Pais creado satisfactoriamente");
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
