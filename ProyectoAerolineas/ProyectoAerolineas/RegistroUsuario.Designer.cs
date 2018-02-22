namespace ProyectoAerolineas
{
    partial class Registro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNombreDeUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.txtConfirmarContrasena = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(206, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtNombreDeUsuario
            // 
            this.txtNombreDeUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreDeUsuario.Location = new System.Drawing.Point(114, 251);
            this.txtNombreDeUsuario.Name = "txtNombreDeUsuario";
            this.txtNombreDeUsuario.Size = new System.Drawing.Size(355, 27);
            this.txtNombreDeUsuario.TabIndex = 1;
            this.txtNombreDeUsuario.Text = "Nombre de Usuario";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.Location = new System.Drawing.Point(114, 357);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(355, 27);
            this.txtContrasena.TabIndex = 3;
            this.txtContrasena.Text = "Contraseña";
            // 
            // txtConfirmarContrasena
            // 
            this.txtConfirmarContrasena.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarContrasena.Location = new System.Drawing.Point(114, 419);
            this.txtConfirmarContrasena.Name = "txtConfirmarContrasena";
            this.txtConfirmarContrasena.Size = new System.Drawing.Size(355, 27);
            this.txtConfirmarContrasena.TabIndex = 4;
            this.txtConfirmarContrasena.Text = "Confirmar Contraseña";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnGuardar.Location = new System.Drawing.Point(152, 492);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(278, 30);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(114, 302);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(355, 27);
            this.txtCedula.TabIndex = 2;
            this.txtCedula.Text = "Cedula";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(23, 548);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(92, 21);
            this.lblMensaje.TabIndex = 6;
            this.lblMensaje.Text = "lblMensaje";
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 589);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtConfirmarContrasena);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtNombreDeUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Registro";
            this.Text = "Registro de Usuario";
            this.Load += new System.EventHandler(this.RegistroUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNombreDeUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.TextBox txtConfirmarContrasena;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lblMensaje;
    }
}