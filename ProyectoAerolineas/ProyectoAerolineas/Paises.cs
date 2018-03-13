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
    public partial class Paises : MetroFramework.Forms.MetroForm
    {
        public Paises()
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

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT id, nombre, bandera FROM paises", conexion);
            adapter.Fill(dataset, "paises");
            dataGridView1.DataSource = dataset.Tables[0];
            dataGridView1.Columns[0].HeaderCell.Value = "ID";
            dataGridView1.Columns[1].HeaderCell.Value = "NOMBRE";
            dataGridView1.Columns[2].HeaderCell.Value = "BANDERA";
            conexion.Close();
        }

        private void Pais_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertarPais();
        }

        private void InsertarPais()
        {
            var pais  = new Pais
            {
                Nombre = txtNombre.Text,


            };

            var paisBo = new PaisesBO();

            try
            {
                paisBo.RegistrarPais(pais);
                MonstrarMensaje("Pais creado satisfactoriamente");
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
            ModificarPais();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EliminarrPais();
        }

        private void ModificarPais()
        {
            var pais = new Pais
            {
                Nombre = txtNombre.Text,


            };

            var paisBo = new PaisesBO();

            try
            {
                paisBo.Modificar(pais);
                MonstrarMensaje("Pais modificado satisfactoriamente");
            }
            catch (Exception e)
            {
                MonstrarError(e.Message);
            }
        }
        private void EliminarrPais()
        {
            var pais = new Pais
            {
                Nombre = txtNombre.Text,


            };

            var paisBo = new PaisesBO();

            try
            {
                if (!txtNombre.Text.Equals(""))
                {
                    paisBo.Eliminaro(txtNombre.Text.Trim());
                    MonstrarMensaje("Pais  eliminado satisfactoriamente");
                }
            }
            catch (Exception e)
            {
                MonstrarError(e.Message);
            }
        }
    }
}
