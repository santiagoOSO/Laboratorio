using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Trabajo_Final
{
    public partial class IngresarSistema : Form
    {
        public IngresarSistema()
        {
            InitializeComponent();

        }
        public void Ingresar()
        {
            try
            {
                string Conexion = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
                using (SqlConnection ConexionBD = new SqlConnection(Conexion))
                {
                    ConexionBD.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT Usuario, Contraseña FROM Ingreso WHERE Usuario ='" + txtUsuario.Text + "' AND Contraseña ='" + txtContraseña.Text + "'", ConexionBD))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
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

                        ConexionBD.Close();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Ingresar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Ingresar Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }

        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Ingresar Usuario";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Ingresar Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Ingresar Contraseña";
                txtUsuario.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }
    }

}
