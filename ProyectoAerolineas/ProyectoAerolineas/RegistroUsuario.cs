using System;
using System.Drawing;
using AerolineasENTIDADES;
using AerolineasNEGOCIO;
using MetroFramework.Forms;

namespace ProyectoAerolineas
{
    public partial class Registro : MetroForm
    {
        public Registro()
        {
            InitializeComponent();
            lblMensaje.Visible = false;
        }

        private void RegistroUsuario_Load(object sender, EventArgs e)
        {
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertarUsuario();
        }

        private void InsertarUsuario()
        {
            var usuario = new Usuario
            {
                Nombre = txtNombreDeUsuario.Text,
                Cedula = txtCedula.Text,
                Contrasena = txtContrasena.Text
            };

            var usuarioBo = new UsuarioBO();

            try
            {
                usuarioBo.RegistrarUsuario(usuario);
                MonstrarMensaje("Usuario creado satisfactoriamente");
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
    }
}