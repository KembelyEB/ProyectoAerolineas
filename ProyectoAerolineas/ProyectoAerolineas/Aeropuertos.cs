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
    public partial class Aeropuertos : MetroFramework.Forms.MetroForm
    {
        public Aeropuertos()
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

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT id, nombre, localidad, iata FROM aeropuertos", conexion);
            adapter.Fill(dataset, "aeropuertos");
            dataGridView1.DataSource = dataset.Tables[0];
            dataGridView1.Columns[0].HeaderCell.Value = "ID";
            dataGridView1.Columns[1].HeaderCell.Value = "NOMBRE";
            dataGridView1.Columns[2].HeaderCell.Value = "LOCALIDAD";
            dataGridView1.Columns[3].HeaderCell.Value = "IATA";
            conexion.Close();
        }

        private void Aeropuerto_Load(object sender, EventArgs e)
        {
            InsertarAeropuerto();
        }

        private void Registrar_Click(object sender, EventArgs e)
        {

        }

        private void InsertarAeropuerto()
        {
            var aeropuerto = new Aeropuerto
            {
                Nombre = txtNombre.Text,
                Localidad= txtLocalidad.Text,
                Iata = txtIata.Text
            };

            var AeropuertoBo = new AeropuertoBO();

            try
            {
                AeropuertoBo.RegistrarAeropuerto(aeropuerto);
                MonstrarMensaje("Aeropuerto creado satisfactoriamente");
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
            ModificarAeropuerto();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EliminarAeropuerto();
        }

        private void ModificarAeropuerto()
        {
            var aeropuerto = new Aeropuerto
            {
                Nombre = txtNombre.Text,
                Localidad = txtLocalidad.Text,
                Iata = txtIata.Text
            };

            var AeropuertoBo = new AeropuertoBO();

            try
            {
                AeropuertoBo.Modificar(aeropuerto);
                MonstrarMensaje("Aeropuerto modificado satisfactoriamente");
            }
            catch (Exception e)
            {
                MonstrarError(e.Message);
            }
        }
        private void EliminarAeropuerto()
        {
            var aeropuerto = new Aeropuerto
            {
                Nombre = txtNombre.Text,
                Localidad = txtLocalidad.Text,
                Iata = txtIata.Text
            };

            var AeropuertoBo = new AeropuertoBO();
            try { 
            if (!txtNombre.Text.Equals(""))
            {
                AeropuertoBo.Eliminaro(txtNombre.Text.Trim());
                MonstrarMensaje("Aeropuerto eliminado satisfactoriamente");
            }
        }

            catch (Exception e)
            {
                MonstrarError(e.Message);
            }
        
        }
    }
}
