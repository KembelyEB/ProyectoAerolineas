using AerolineasDATOS;
using AerolineasENTIDADES;
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
    public partial class BuscaVuelo : MetroFramework.Forms.MetroForm
    {
        public BuscaVuelo()
        {
            InitializeComponent();
           
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

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT id, pais_origen, pais_destino, duracion  FROM rutas", conexion);
            adapter.Fill(dataset, "estudiante");
            dataGridView1.DataSource = dataset.Tables[0];
            dataGridView1.Columns[0].HeaderCell.Value = "ID";
            dataGridView1.Columns[1].HeaderCell.Value = "ORIGEN";
            dataGridView1.Columns[2].HeaderCell.Value = "DESTINO";
            dataGridView1.Columns[3].HeaderCell.Value = "DURACION";
            conexion.Close();
        }

        public void CargarH()
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

        public void CargarV()
        {
            Conexion();
            conexion.Open();
            DataSet dataset = new DataSet();

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT id, marca, modelo, tipo, precio, cantidad FROM vehiculos", conexion);
            adapter.Fill(dataset, "vehiculos");
            dataGridView1.DataSource = dataset.Tables[0];
            dataGridView1.Columns[0].HeaderCell.Value = "ID";
            dataGridView1.Columns[1].HeaderCell.Value = "MARCA";
            dataGridView1.Columns[2].HeaderCell.Value = "MODELO";
            dataGridView1.Columns[3].HeaderCell.Value = "TIPO";
            dataGridView1.Columns[3].HeaderCell.Value = "PRECIO";
            dataGridView1.Columns[3].HeaderCell.Value = "CANTIDAD";
            conexion.Close();
        }


        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void BuscaVuelo_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            InsertarReservaVuelo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarGrit();
        }


        private void InsertarReservaVuelo()
        {
            var reservaVuelo = new ReservaVuelos
            {
                Origen = txtOrigen.Text,
                Destino = txtDestino.Text,
                salida  = dtIDA.Value.ToString("dd/MM/yyyy"),
                llegada = dtLLEGADA.Value.ToString("dd/MM/yyyy"),
                Pasajeros = txtPasajeros.Text,
                id_Ruta = dataGridView1.CurrentRow.Cells[0].Value.ToString()

            };

            var  rVuelo = new ReservaVuelo();

            try
            {
                rVuelo.InsertarDatos(reservaVuelo);
                MonstrarMensaje("Reserva Vuelo  creado satisfactoriamente");
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

        private void button3_Click(object sender, EventArgs e)
        {

            CargarH();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InsertarReservaH();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CargarV();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            InsertarReservaV();
        }


        private void InsertarReservaH()
        {
            var reservaH = new ReservasHotel
            {
                destino= textBox4.Text,
                entrada = dateTimePicker3.Value.ToString("dd/MM/yyyy"),
                salida = dateTimePicker4.Value.ToString("dd/MM/yyyy"),
                habitaciones = textBox5.Text,
                id_Hotels = dataGridView2.CurrentRow.Cells[0].Value.ToString()

            };

            var rHotel = new ReservaHotel();

            try
            {
                rHotel.InsertarDatos(reservaH);
                MonstrarMensaje("Reserva Hotel creado satisfactoriamente");
            }
            catch (Exception e)
            {
                MonstrarError(e.Message);
            }
        }


        private void InsertarReservaV()
        {
            var reservaVehi = new ReservasVehiculo
            {
                tipoAuto = textBox6.Text,
                Retira = dateTimePicker5.Value.ToString("dd/MM/yyyy"),
                Entrega = dateTimePicker6.Value.ToString("dd/MM/yyyy"),
                id_Vehiculos= dataGridView3.CurrentRow.Cells[0].Value.ToString()

            };

            var rVehi = new ReservaVehiculo();

            try
            {
                rVehi.InsertarDatos(reservaVehi);
                MonstrarMensaje("Reserva Vehiculo creado satisfactoriamente");
            }
            catch (Exception e)
            {
                MonstrarError(e.Message);
            }
        }

    }
}
