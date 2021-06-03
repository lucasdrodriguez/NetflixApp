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
    public partial class MenuPrincipal : Form
    {

        string usuario;

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        public string UsuarioLogueado
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

            comboBox1.DataSource = Enum.GetValues(typeof(EGenero));
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;


        }

    }
}
