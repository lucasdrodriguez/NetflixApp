using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetflixCore;
using NetflixCore.Personas;


namespace NetflixUI
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();

        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.tb_usuario.Text = "";
            this.tb_contrasenia.Text = "";
            this.btn_iniciar.Text = "Inicial Sesion";
            this.ControlBox = false;
            this.tb_contrasenia.UseSystemPasswordChar = true;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {

            Usuario aux = CoreDelSistema.LogearUsuario(this.tb_usuario.Text, this.tb_contrasenia.Text);

            if (aux != null)
            {
                MenuPrincipal principal = new MenuPrincipal(aux);

                principal.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_registrarse_Click(object sender, EventArgs e)
        {
        }
    }
}
