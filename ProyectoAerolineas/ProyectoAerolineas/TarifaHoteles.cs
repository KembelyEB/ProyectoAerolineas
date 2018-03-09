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
    public partial class TarifaHoteles : MetroFramework.Forms.MetroForm
    {

    
        public TarifaHoteles()
        {
            InitializeComponent();
        }

        private void TarifaHoteles_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertarTarifaHotel();
        }

        private void InsertarTarifaHotel()
        {
            var tHotel = new TarifaHotel
            {
                Precio = txtPrecio.Text,
               


            };

            var taHotelBo = new TarifaHotelBO();

            try
            {
                taHotelBo.RegistrarTarifaHotel(tHotel);
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

        private void button2_Click(object sender, EventArgs e)
        {
            ModificarTarifaHotel();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EliminarTarifaHotel();
        }

        private void ModificarTarifaHotel()
        {
            var tHotel = new TarifaHotel
            {
                Precio = txtPrecio.Text,



            };

            var taHotelBo = new TarifaHotelBO();

            try
            {
                taHotelBo.Modificar(tHotel);
                MonstrarMensaje("Tarifa hotel modificado satisfactoriamente");
            }
            catch (Exception e)
            {
                MonstrarError(e.Message);
            }
        }
        private void EliminarTarifaHotel()
        {
            var tHotel = new TarifaHotel
            {
                Precio = txtPrecio.Text,



            };

            var taHotelBo = new TarifaHotelBO();

            try
            {
                if (!txtPrecio.Text.Equals(""))
                {
                    taHotelBo.Eliminar(txtPrecio.Text.Trim());
                    MonstrarMensaje(" Tarifa de Hotel eliminado satisfactoriamente");
                }
            }
            catch (Exception e)
            {
                MonstrarError(e.Message);
            }
        }
    }
}
