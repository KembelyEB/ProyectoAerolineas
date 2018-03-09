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
    public partial class Hotels : MetroFramework.Forms.MetroForm
    {
        public Hotels()
        {
            InitializeComponent();
        }

        private void Hotel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertarHotel();
        }

        private void InsertarHotel()
        {
            var hotel = new Hotel
            {
                Nombre = txtNombre.Text,
                Pais = txtPais.Text,
                Lugar = txtLugar.Text,
                Habitacion = txtPais.Text,
               
            };

            var hotelBo = new HotelBO();

            try
            {
                hotelBo.RegistrarHotel(hotel);
                MonstrarMensaje("hotel creado satisfactoriamente");
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
            ModificarHotel();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EliminarHotel();
        }

        private void ModificarHotel()
        {
            var hotel = new Hotel
            {
                Nombre = txtNombre.Text,
                Pais = txtPais.Text,
                Lugar = txtLugar.Text,
                Habitacion = txtPais.Text,

            };

            var hotelBo = new HotelBO();

            try
            {
                hotelBo.Modificar(hotel);
                MonstrarMensaje("hotel modificado satisfactoriamente");
            }
            catch (Exception e)
            {
                MonstrarError(e.Message);
            }
        }
        private void EliminarHotel()
        {
            var hotel = new Hotel
            {
                Nombre = txtNombre.Text,
              

            };

            var hotelBo = new HotelBO();

            try
            {
                if (!txtNombre.Text.Equals(""))
                {
                    hotelBo.Eliminar(txtNombre.Text.Trim());
                    MonstrarMensaje("hotel eliminado satisfactoriamente");
                }
            }
            catch (Exception e)
            {
                MonstrarError(e.Message);
            }
        }

    }
}
