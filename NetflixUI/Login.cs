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

namespace NetflixUI
{
    public partial class Login : Template
    {

        public Login() : base()
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
            try
            {
                if (CoreDelSistema.LogearUsuario(this.tb_usuario.Text, this.tb_contrasenia.Text))
                {
                    MenuPrincipal principal = new MenuPrincipal();
                    principal.UsuarioLogueado = this.tb_usuario.Text;
                    principal.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta");
                }
            }
            catch (Exception ex )
            {

                this.lb_error.Text = ex.Message;
    
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
