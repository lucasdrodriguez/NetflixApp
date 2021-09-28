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
    public partial class MenuPrincipal: Form
    {

        Usuario usuario;

        public MenuPrincipal(Usuario aux)
        {
            InitializeComponent();
            usuario = aux;
        }

        public Usuario UsuarioLogueado
        {
            get
            {
                return usuario;
            }
            set
            {
                usuario = value;
            }
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

            if(usuario is Celebridad)
            {
                comboBox1.Enabled = false;
                comboBox1.Visible = false;
            }
            
            comboBox1.DataSource = Enum.GetValues(typeof(EGenero));
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Text = "Seleccionar Genero";

        }

    }
}
