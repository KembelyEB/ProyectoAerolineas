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
    public partial class Lugars : MetroFramework.Forms.MetroForm
    {
        public Lugars()
        {
            InitializeComponent();
        }

        private void Lugar_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void InsertarLugar()
        {
            var lugar = new Lugar
            {
                Nombre = txtNombre.Text,
              

            };

            var lugarBo = new LugarBO();

            try
            {
                lugarBo.RegistrarLugar(lugar);
                MonstrarMensaje("Lugar creado satisfactoriamente");
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
            ModificarLugar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EliminarLugar();  
        }

        private void ModificarLugar()
        {
            var lugar = new Lugar
            {
                Nombre = txtNombre.Text,


            };

            var lugarBo = new LugarBO();

            try
            {
                lugarBo.Modificar(lugar);
                MonstrarMensaje("Lugar modificado satisfactoriamente");
            }
            catch (Exception e)
            {
                MonstrarError(e.Message);
            }
        }
        private void EliminarLugar()
        {
            var lugar = new Lugar
            {
                Nombre = txtNombre.Text,


            };

            var lugarBo = new LugarBO();

            try
            {
                if (!txtNombre.Text.Equals(""))
                {
                    lugarBo.Eliminaro(txtNombre.Text.Trim());
                    MonstrarMensaje("Lugar eliminado satisfactoriamente");
                }
               
            }
            catch (Exception e)
            {
                MonstrarError(e.Message);
            }
        }
    }
}
