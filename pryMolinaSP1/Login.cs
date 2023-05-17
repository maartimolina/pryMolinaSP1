using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pryMolinaSP1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if(txtUsuario.Text.Length >=10) 
            {
                txtUsuario.Text = txtUsuario.Text.Substring(0, 10);
                txtUsuario.SelectionStart = 10;
            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            if (txtContraseña.Text.Length >= 10)
            {
                txtContraseña.Text = txtContraseña.Text.Substring(0, 10);
                txtContraseña.SelectionStart = 10;
         
      
            }
            txtContraseña.Text = new string('#', txtContraseña.Text.Length);

        }


    }
}
