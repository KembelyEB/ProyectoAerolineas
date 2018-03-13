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
    public partial class Hotels : MetroFramework.Forms.MetroForm
    {
        public Hotels()
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

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT id, nombre, foto, pais, lugar, habitaciones  FROM hoteles", conexion);
            adapter.Fill(dataset, "hoteles");
            dataGridView1.DataSource = dataset.Tables[0];
            dataGridView1.Columns[0].HeaderCell.Value = "ID";
            dataGridView1.Columns[1].HeaderCell.Value = "NOMBRE";
            dataGridView1.Columns[2].HeaderCell.Value = "FOTO";
            dataGridView1.Columns[3].HeaderCell.Value = "PAIS";
            dataGridView1.Columns[4].HeaderCell.Value = "LUGAR";
            dataGridView1.Columns[5].HeaderCell.Value = "HABITACIONES";
            conexion.Close();
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
