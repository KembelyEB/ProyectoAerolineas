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
    public partial class Rutass : MetroFramework.Forms.MetroForm
    {
        public Rutass()
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

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT id, pais_origen, pais_destino, duracion FROM rutas", conexion);
            adapter.Fill(dataset, "rutas");
            dataGridView1.DataSource = dataset.Tables[0];
            dataGridView1.Columns[0].HeaderCell.Value = "ID";
            dataGridView1.Columns[1].HeaderCell.Value = "PAIS ORIGEN";
            dataGridView1.Columns[2].HeaderCell.Value = "PAIS DESTINO";
            dataGridView1.Columns[3].HeaderCell.Value = "DURACION";

            conexion.Close();
        }


        private void Ruta_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertarRuta();
        }

        private void InsertarRuta()
        {
            var ruta = new Ruta
            {
                Duracion = txtDuracion.Text,
                Pais_Origen = txtPaisOrigen.Text,
                Pais_Destino = txtPaisDestino.Text,


            };

            var rutaBo = new RutaBO();

            try
            {
                rutaBo.RegistrarRuta(ruta);
                MonstrarMensaje("Ruta creado satisfactoriamente");
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

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void ModificarrRuta()
        {
            var ruta = new Ruta
            {
                Duracion = txtDuracion.Text,
                Pais_Origen = txtPaisOrigen.Text,
                Pais_Destino = txtPaisDestino.Text,


            };

            var rutaBo = new RutaBO();

            try
            {
                rutaBo.Modificar(ruta);
                MonstrarMensaje("Ruta modificada satisfactoriamente");
            }
            catch (Exception e)
            {
                MonstrarError(e.Message);
            }
        }
        private void EliminarRuta()
        {
            var ruta = new Ruta
            {
                Duracion = txtDuracion.Text,
                Pais_Origen = txtPaisOrigen.Text,
                Pais_Destino = txtPaisDestino.Text,


            };

            var rutaBo = new RutaBO();

            try
            {
                if (!txtDuracion.Text.Equals(""))
                {
                    rutaBo.Eliminaro(txtDuracion.Text.Trim());
                    MonstrarMensaje("Ruta eliminado satisfactoriamente");
                }
            }
            catch (Exception e)
            {
                MonstrarError(e.Message);
            }
        }
    }
}
