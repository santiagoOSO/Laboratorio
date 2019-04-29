using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_Final
{
    public partial class IngresarSistema : Form
    {
        public IngresarSistema()
        {
            InitializeComponent();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            string[,] arreglo = { { "wortiz" }, { "1234" } };

            if (txtUsuario.Text == arreglo[0, 0] && txtContraseña.Text == arreglo[1, 0])
           {
               this.Hide();
               MDIPaciente p = new MDIPaciente();
               p.Show();
           }

           else

           {
               
               MessageBox.Show("Error de autenticacion, verifique usuario y/o contraseña ó es posible que su cuenta este inhabilitada", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
               txtContraseña.Text = "";
               txtUsuario.Text = "";

           }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
