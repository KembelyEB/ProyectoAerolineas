using AerolineasENTIDADES;
using AerolineasNEGOCIO;
using Npgsql;
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
            CargarGrit();

        }

        static NpgsqlConnection conexion;
        static NpgsqlCommand cmd;

        public static void Conexion()
        {
            string servidor = "localhost";
            int puerto = 5432;
            string usuario = "postgres";
            String clave = "lanegra15";
            string baseDatos = "aerolineas";

            string cadenaConexion = "Server=" + servidor + ";" + "Port=" + puerto + ";" + "User Id=" + usuario + ";" + "Password=" + clave + ";" + "Database=" + baseDatos;
            conexion = new NpgsqlConnection(cadenaConexion);
        }

        public void CargarGrit()
        {
            Conexion();
            conexion.Open();
            DataSet dataset = new DataSet();

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT id, marca, modelo, tipo, precio, cantidad FROM vehiculos", conexion);
            adapter.Fill(dataset, "Vehiculos");
            dataGridView1.DataSource = dataset.Tables[0];
            dataGridView1.Columns[0].HeaderCell.Value = "ID";
            dataGridView1.Columns[1].HeaderCell.Value = "MARCA";
            dataGridView1.Columns[2].HeaderCell.Value = "MODELO";
            dataGridView1.Columns[3].HeaderCell.Value = "TIPO";
            dataGridView1.Columns[4].HeaderCell.Value = "PRECIO";
            dataGridView1.Columns[5].HeaderCell.Value = "CANTIDAD";
            conexion.Close();
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
