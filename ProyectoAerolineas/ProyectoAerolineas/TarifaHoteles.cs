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
    public partial class TarifaHoteles : MetroFramework.Forms.MetroForm
    {

    
        public TarifaHoteles()
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

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT id, precio  FROM tarifahoteles", conexion);
            adapter.Fill(dataset, "tarifashoteles");
            dataGridView1.DataSource = dataset.Tables[0];
            dataGridView1.Columns[0].HeaderCell.Value = "ID";
            dataGridView1.Columns[1].HeaderCell.Value = "PRECIO";
            conexion.Close();
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
