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
    public partial class Vehiculos : MetroFramework.Forms.MetroForm
    {
        public Vehiculos()
        {
            InitializeComponent();
        }

        private void Vehiculo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertarVehiculo();
        }

        private void InsertarVehiculo()
        {
            var vehiculo = new Vehiculo
            {
                Marca = txtMarca.Text,
                Modelo = txtModelo.Text,
                Tipo = txtTipo.Text,
                Precio = txtPrecio.Text,
                Cantidad = txtPrecio.Text,
            


            };

            var vehiculoBo = new VehiculoBO();

            try
            {
                vehiculoBo.RegistrarVehiculo(vehiculo);
                MonstrarMensaje("Vehiculo creado satisfactoriamente");
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
            ModificarVehiculo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EliminarVehiculo();
        }
        private void ModificarVehiculo()
        {
            var vehiculo = new Vehiculo
            {
                Marca = txtMarca.Text,
                Modelo = txtModelo.Text,
                Tipo = txtTipo.Text,
                Precio = txtPrecio.Text,
                Cantidad = txtPrecio.Text,



            };

            var vehiculoBo = new VehiculoBO();

            try
            {
                vehiculoBo.ModificarVehiculo(vehiculo);
                MonstrarMensaje("Vehiculo modificado satisfactoriamente");
            }
            catch (Exception e)
            {
                MonstrarError(e.Message);
            }
        }
        private void EliminarVehiculo()
        {
            var vehiculo = new Vehiculo
            {
                Marca = txtMarca.Text,
                Modelo = txtModelo.Text,
                Tipo = txtTipo.Text,
                Precio = txtPrecio.Text,
                Cantidad = txtPrecio.Text,



            };

            var vehiculoBo = new VehiculoBO();

            try
            {
                  if (!txtMarca.Text.Equals(""))
                {
                    vehiculoBo.EliminarVehiculo(txtMarca.Text.Trim());
                    MonstrarMensaje("Vehiculo eliminado satisfactoriamente");
                }
            }
            catch (Exception e)
            {
                MonstrarError(e.Message);
            }
        }
    }
}
