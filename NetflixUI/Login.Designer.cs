
namespace NetflixUI
{
    partial class Login
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
            this.tb_usuario = new System.Windows.Forms.TextBox();
            this.tb_contrasenia = new System.Windows.Forms.TextBox();
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_registrarse = new System.Windows.Forms.Button();
            this.lb_error = new System.Windows.Forms.Label();
            this.btn_datosHardcodeados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_usuario
            // 
            this.tb_usuario.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_usuario.ForeColor = System.Drawing.Color.White;
            this.tb_usuario.Location = new System.Drawing.Point(252, 143);
            this.tb_usuario.Name = "tb_usuario";
            this.tb_usuario.Size = new System.Drawing.Size(195, 23);
            this.tb_usuario.TabIndex = 0;
            // 
            // tb_contrasenia
            // 
            this.tb_contrasenia.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_contrasenia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_contrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_contrasenia.ForeColor = System.Drawing.Color.White;
            this.tb_contrasenia.Location = new System.Drawing.Point(252, 185);
            this.tb_contrasenia.Name = "tb_contrasenia";
            this.tb_contrasenia.Size = new System.Drawing.Size(195, 23);
            this.tb_contrasenia.TabIndex = 1;
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.BackColor = System.Drawing.Color.Red;
            this.btn_iniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_iniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_iniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_iniciar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_iniciar.Location = new System.Drawing.Point(252, 246);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(195, 33);
            this.btn_iniciar.TabIndex = 2;
            this.btn_iniciar.Text = "Iniciar Sesion";
            this.btn_iniciar.UseVisualStyleBackColor = false;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.Maroon;
            this.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_salir.ForeColor = System.Drawing.Color.FloralWhite;
            this.btn_salir.Location = new System.Drawing.Point(611, 415);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 3;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_registrarse
            // 
            this.btn_registrarse.BackColor = System.Drawing.Color.Red;
            this.btn_registrarse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_registrarse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_registrarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_registrarse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_registrarse.Location = new System.Drawing.Point(291, 297);
            this.btn_registrarse.Name = "btn_registrarse";
            this.btn_registrarse.Size = new System.Drawing.Size(120, 40);
            this.btn_registrarse.TabIndex = 4;
            this.btn_registrarse.Text = "Registrarse";
            this.btn_registrarse.UseVisualStyleBackColor = false;
            // 
            // lb_error
            // 
            this.lb_error.AutoSize = true;
            this.lb_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_error.ForeColor = System.Drawing.Color.Snow;
            this.lb_error.Location = new System.Drawing.Point(297, 363);
            this.lb_error.Name = "lb_error";
            this.lb_error.Size = new System.Drawing.Size(0, 42);
            this.lb_error.TabIndex = 6;
            // 
            // btn_datosHardcodeados
            // 
            this.btn_datosHardcodeados.BackColor = System.Drawing.Color.Red;
            this.btn_datosHardcodeados.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_datosHardcodeados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_datosHardcodeados.ForeColor = System.Drawing.Color.Snow;
            this.btn_datosHardcodeados.Location = new System.Drawing.Point(241, 383);
            this.btn_datosHardcodeados.Name = "btn_datosHardcodeados";
            this.btn_datosHardcodeados.Size = new System.Drawing.Size(239, 35);
            this.btn_datosHardcodeados.TabIndex = 7;
            this.btn_datosHardcodeados.Text = "Datos Hardcodeados";
            this.btn_datosHardcodeados.UseVisualStyleBackColor = false;
            this.btn_datosHardcodeados.Click += new System.EventHandler(this.btn_datosHardcodeados_Click);
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::NetflixUI.Properties.Resources.FondoLogin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(698, 450);
            this.Controls.Add(this.btn_datosHardcodeados);
            this.Controls.Add(this.lb_error);
            this.Controls.Add(this.btn_registrarse);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_iniciar);
            this.Controls.Add(this.tb_contrasenia);
            this.Controls.Add(this.tb_usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_usuario;
        private System.Windows.Forms.TextBox tb_contrasenia;
        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_registrarse;
        private System.Windows.Forms.Label lb_error;
        private System.Windows.Forms.Button btn_datosHardcodeados;
    }
}