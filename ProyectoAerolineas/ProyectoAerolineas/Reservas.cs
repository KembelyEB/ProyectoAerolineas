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
    public partial class Reservas : MetroFramework.Forms.MetroForm
    {
        public Reservas()
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

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT id, origen, destino, salida, llegada, id_ruta FROM reservaVuelos", conexion);
            adapter.Fill(dataset, "ReservaVuelos");
            dataGridView1.DataSource = dataset.Tables[0];
            dataGridView1.Columns[0].HeaderCell.Value = "ID";
            dataGridView1.Columns[1].HeaderCell.Value = "ORIGEN";
            dataGridView1.Columns[2].HeaderCell.Value = "DESTINO";
            dataGridView1.Columns[3].HeaderCell.Value = "SALIDA";
            dataGridView1.Columns[4].HeaderCell.Value = "LLEGADA";
            dataGridView1.Columns[5].HeaderCell.Value = "ID_RUTA";
            conexion.Close();
        }
        public void CargarRHOTEL()
        {
            Conexion();
            conexion.Open();
            DataSet dataset = new DataSet();

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT id, destino, entrada, salida, habitaciones id_Hotel FROM reservaHotel", conexion);
            adapter.Fill(dataset, "ReservaHotel");
            dataGridView1.DataSource = dataset.Tables[0];
            dataGridView1.Columns[0].HeaderCell.Value = "ID";
            dataGridView1.Columns[1].HeaderCell.Value = "DESTINO";
            dataGridView1.Columns[2].HeaderCell.Value = "ENTRADA";
            dataGridView1.Columns[3].HeaderCell.Value = "SALIDA";
            dataGridView1.Columns[4].HeaderCell.Value = "HABITACIONES";
            dataGridView1.Columns[5].HeaderCell.Value = "ID_HOTEL";
            conexion.Close();
        }
        public void CargarRVEHICULO()
        {
            Conexion();
            conexion.Open();
            DataSet dataset = new DataSet();

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT id, tipoAuto, retira, entrega, id_vehiculo FROM reservaVehiculo", conexion);
            adapter.Fill(dataset, "ReservaVehiculo");
            dataGridView1.DataSource = dataset.Tables[0];
            dataGridView1.Columns[0].HeaderCell.Value = "ID";
            dataGridView1.Columns[1].HeaderCell.Value = "TIPOAUTO";
            dataGridView1.Columns[2].HeaderCell.Value = "RETIRA";
            dataGridView1.Columns[3].HeaderCell.Value = "ENTREGA";
            dataGridView1.Columns[4].HeaderCell.Value = "ID_VEHICULO";
            conexion.Close();
        }

        private void Reservas_Load(object sender, EventArgs e)
        {

        }
    }
}
