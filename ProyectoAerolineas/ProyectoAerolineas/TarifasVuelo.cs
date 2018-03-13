﻿using AerolineasENTIDADES;
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
    public partial class TarifasVuelo : MetroFramework.Forms.MetroForm
    {
        public TarifasVuelo()
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

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT id, ruta, precio FROM tarifavuelos", conexion);
            adapter.Fill(dataset, "tarifavuelos");
            dataGridView1.DataSource = dataset.Tables[0];
            dataGridView1.Columns[0].HeaderCell.Value = "ID";
            dataGridView1.Columns[1].HeaderCell.Value = "RUTA";
            dataGridView1.Columns[2].HeaderCell.Value = "PRECIO";
            conexion.Close();
        }

        private void TarifaVuelo_Load(object sender, EventArgs e)
        {

        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            InsertarTarifaVuelo();
        }

        private void InsertarTarifaVuelo()
        {
            var tVuelo = new TarifaVuelo
            {

                Ruta = txtRuta.Text,
                Precio = txtPrecio.Text,



            };

            var taVueloBo = new TarifaVueloBO();

            try
            {
                taVueloBo.RegistrarLugar(tVuelo);
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

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }


        private void ModificarTarifaVuelo()
        {
            var tVuelo = new TarifaVuelo
            {

                Ruta = txtRuta.Text,
                Precio = txtPrecio.Text,



            };

            var taVueloBo = new TarifaVueloBO();

            try
            {
                taVueloBo.Modificar(tVuelo);
                MonstrarMensaje("Tarifa hotel creado satisfactoriamente");
            }
            catch (Exception e)
            {
                MonstrarError(e.Message);
            }
        }

        private void EliminarTarifaVuelo()
        {
            var tVuelo = new TarifaVuelo
            {

                Ruta = txtRuta.Text,
                Precio = txtPrecio.Text,



            };

            var taVueloBo = new TarifaVueloBO();

            try
            {
                if (!txtRuta.Text.Equals(""))
                {
                    taVueloBo.Eliminaro(txtRuta.Text.Trim());
                    MonstrarMensaje("Tarifa Vuelo  eliminado satisfactoriamente");
                }
            }
            catch (Exception e)
            {
                MonstrarError(e.Message);
            }
        }


    }
}
