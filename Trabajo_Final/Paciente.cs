using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using Entidades;

namespace Trabajo_Final
{
    public partial class Paciente : Form
    {
        //Conexion c = new Conexion();
        public Paciente()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    string Conexion = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
                    using (SqlConnection ConexionBD = new SqlConnection(Conexion))
                    {
                        ConexionBD.Open();
                        SqlCommand cmd;
                        cmd = new SqlCommand("Insert Into Pacientes([IdTipoIdentificacion], [NumeroIdentificacion], [PrimerNombre], [SegundoNombre], [PrimerApellido], [SegundoApellido], [IdSexo], [FechaNacimiento], [Edad], [IdEstadoCivil], [Direccion], [Barrio], [Telefono], [Ocupacion], [IdNivelEscolaridad], [IdEps], [IdRegimen], [Email],[ContactoEmergencia],[Antecedentes]) values (@IdTipoIdentificacion,@NumeroIdentificacion,@PrimerNombre,@SegundoNombre,@PrimerApellido,@SegundoApellido,@IdSexo,@FechaNacimiento,@Edad,@IdEstadoCivil,@Direccion,@Barrio,@Telefono,@Ocupacion,@IdNivelEscolaridad,@IdEps,@IdRegimen,@Email,@ContactoEmergencia,@Antecedentes)", ConexionBD);

                        //SqlCommand cmd = new SqlCommand(comando, ConexionBD);


                        cmd.Parameters.AddWithValue("@IdTipoIdentificacion", (cboTipoDocumento.SelectedItem as TipoDocumento).Id);
                        cmd.Parameters.AddWithValue("@NumeroIdentificacion", txtNumeroDocumento.Text);
                        cmd.Parameters.AddWithValue("@PrimerNombre", txtPrimerNombre.Text);
                        cmd.Parameters.AddWithValue("@SegundoNombre", txtSegundoNombre.Text);
                        cmd.Parameters.AddWithValue("@PrimerApellido", txtPrimerApellido.Text);
                        cmd.Parameters.AddWithValue("@SegundoApellido", txtSegundoApellido.Text);
                        cmd.Parameters.AddWithValue("@IdSexo", (cboGenero.SelectedItem as Genero).Id);
                        cmd.Parameters.AddWithValue("@FechaNacimiento", dtpFechaNacimiento.Value);
                        cmd.Parameters.AddWithValue("@Edad", txtEdad.Text);
                        cmd.Parameters.AddWithValue("@IdEstadoCivil", (cboEstadoCivil.SelectedItem as EstadoCivil).Id);
                        cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                        cmd.Parameters.AddWithValue("@Barrio", txtBarrio.Text);
                        cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                        cmd.Parameters.AddWithValue("@Ocupacion", txtOcupacion.Text);
                        cmd.Parameters.AddWithValue("@IdNivelEscolaridad", (cboNivelEscolaridad.SelectedItem as NivelEscolaridad).Id);
                        cmd.Parameters.AddWithValue("@IdEps", (cboEPS.SelectedItem as EPS).Id);
                        cmd.Parameters.AddWithValue("@IdRegimen", (cboRegimen.SelectedItem as Regimen).Id);
                        cmd.Parameters.AddWithValue("@Email", txtCorreoElectronico.Text);
                        cmd.Parameters.AddWithValue("@ContactoEmergencia", txtContactoEmergencia.Text);
                        cmd.Parameters.AddWithValue("@Antecedentes", txtAntecedentes.Text);
                        
                        cmd.ExecuteNonQuery();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
            if (!ValidarDatos())
            {
                return;
            }

            var paciente = new Entidades.Paciente()

            {
                PrimerNombre = txtPrimerNombre.Text,
                SegundoNombre = txtSegundoNombre.Text,
                PrimerApellido = txtPrimerApellido.Text,
                SegundoApellido = txtPrimerApellido.Text,
                TipoDocumento = cboTipoDocumento.SelectedItem as TipoDocumento,
                NumeroDocumento = txtNumeroDocumento.Text,
                Genero = cboGenero.SelectedItem as Genero,
                FechaNacimiento = dtpFechaNacimiento.Value,
                EstadoCivil = cboEstadoCivil.SelectedItem as EstadoCivil,
                Direccion = txtDireccion.Text,
                Barrio = txtBarrio.Text,
                Telefono = txtTelefono.Text,
                Ocupacion = txtOcupacion.Text,
                NivelEscolaridad = cboNivelEscolaridad.SelectedItem as NivelEscolaridad,
                EPS = cboEPS.SelectedItem as EPS,
                Regimen = cboRegimen.SelectedItem as Regimen,
                CorreoElectronico = txtCorreoElectronico.Text,
                ContactoEmergencia = txtContactoEmergencia.Text,
                Antecedente = txtAntecedentes.Text,

            };

            MessageBox.Show("Los datos se han guardado exitosamente");

        }

        private bool ValidarDatos()
        {
            //PRIMER NOMBRE
            if (string.IsNullOrEmpty(txtPrimerNombre.Text.Trim()))
            {
                erpMensaje.SetError(txtPrimerNombre, "Por favor ingrese el primer nombre");
                return false;
            }
            else
            {
                erpMensaje.SetError(txtPrimerNombre, null);
            }

            //PRIMER APELLIDO
            if (string.IsNullOrEmpty(txtPrimerApellido.Text.Trim()))
            {
                erpMensaje.SetError(txtPrimerApellido, "Por favor ingrese el primer apellido");
                return false;
            }
            else
            {
                erpMensaje.SetError(txtPrimerApellido, null);
            }

            //TIPO DOCUMENTO
            if (cboTipoDocumento.SelectedItem == null)
            {
                erpMensaje.SetError(cboTipoDocumento, "Por favor seleccione el tipo de documento");
                return false;
            }
            else
            {
                erpMensaje.SetError(cboTipoDocumento, null);
            }

            //NUMERO DOCUMENTO
            if (string.IsNullOrEmpty(txtNumeroDocumento.Text.Trim()))
            {
                erpMensaje.SetError(txtNumeroDocumento, "Por favor ingrese el número de documento");
                return false;
            }
            else
            {
                erpMensaje.SetError(txtNumeroDocumento, null);
            }

            //GENERO
            if (cboGenero.SelectedItem == null)
            {
                erpMensaje.SetError(cboGenero, "Por favor seleccione el genero");
                return false;
            }
            else
            {
                erpMensaje.SetError(cboGenero, null);
            }

            //FECHA NACIMIENTO
            DateTime fechaNacimiento = dtpFechaNacimiento.Value;
            if (fechaNacimiento > DateTime.Now)
            {
                erpMensaje.SetError(dtpFechaNacimiento, "La fecha de nacimiento no debe ser mayor a la fecha del sistema");
                return false;
            }
            else
            {
                erpMensaje.SetError(dtpFechaNacimiento, null);
            }

            //ESTADO CIVIL
            if (cboEstadoCivil.SelectedItem == null)
            {
                erpMensaje.SetError(cboEstadoCivil, "Por favor seleccione el Estado Civil");
                return false;
            }
            else
            {
                erpMensaje.SetError(cboEstadoCivil, null);
            }

            //DIRECCION
            if (string.IsNullOrEmpty(txtDireccion.Text.Trim()))
            {
                erpMensaje.SetError(txtDireccion, "Por favor ingrese la dirección");
                return false;
            }
            else
            {
                erpMensaje.SetError(txtDireccion, null);
            }

            //BARRIO
            if (string.IsNullOrEmpty(txtBarrio.Text.Trim()))
            {
                erpMensaje.SetError(txtBarrio, "Por favor ingrese el barrio");
                return false;
            }
            else
            {
                erpMensaje.SetError(txtBarrio, null);
            }

            //OCUPACION 
            if (string.IsNullOrEmpty(txtOcupacion.Text.Trim()))
            {
                erpMensaje.SetError(txtOcupacion, "Por favor ingrese la Ocupacion");
                return false;
            }
            else
            {
                erpMensaje.SetError(txtOcupacion, null);
            }

            //NIVEL DE ESCOLARIDAD
            if (cboNivelEscolaridad.SelectedItem == null)
            {
                erpMensaje.SetError(cboNivelEscolaridad, "Por favor seleccione el Nivel de Escolaridad");
                return false;
            }
            else
            {
                erpMensaje.SetError(cboNivelEscolaridad, null);
            }

            //EPS
            if (cboEPS.SelectedItem == null)
            {
                erpMensaje.SetError(cboEPS, "Por favor seleccione la EPS");
                return false;
            }
            else
            {
                erpMensaje.SetError(cboEPS, null);
            }

            //REGIMEN
            if (cboRegimen.SelectedItem == null)
            {
                erpMensaje.SetError(cboRegimen, "Por favor seleccione el Regimen");
                return false;
            }
            else
            {
                erpMensaje.SetError(cboRegimen, null);
            }

       return true;
        }

        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaNacimiento.Value > DateTime.Now)
            {
                erpMensaje.SetError(dtpFechaNacimiento, "La fecha de nacimiento no debe ser mayor a la fecha del sistema");

            }
            else
            {
                txtEdad.Text = (DateTime.Today.AddTicks(-dtpFechaNacimiento.Value.Ticks).Year - 1).ToString();
                txtEdad.Enabled = false;
            }
        }

        private void Paciente_Load(object sender, EventArgs e)
        {
            cboTipoDocumento.SelectedIndex = 0;
            LLenarComboTipoDocumento();
            LlenarComboGenero();
            LlenarComboEstadoCivil();
            LLenarComboEps();
            LlenarComboNivelEscolar();
            LLenarComboTipoRegimen();

        }

        private void LLenarComboTipoRegimen()
        {
            List<Regimen> regimen = new List<Regimen>();
            try
            {
                string Conexion = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
                using (SqlConnection ConexionBD = new SqlConnection(Conexion))
                {

                    ConexionBD.Open();

                    SqlCommand comando = new SqlCommand();

                    comando.CommandText = "SELECT IdRegimen, Nombre FROM Regimen";
                    comando.Connection = ConexionBD;

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            regimen.Add(new Regimen()
                            {
                                Id = Convert.ToInt32(reader["IdRegimen"]),
                                Nombre = (string)reader["Nombre"]
                            });
                        }
                    }
                }

                cboRegimen.DataSource = regimen;
                cboRegimen.DisplayMember = "Nombre";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void LlenarComboNivelEscolar()
        {
            List<NivelEscolaridad> Nescolar = new List<NivelEscolaridad>();
            try
            {
                string Conexion = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
                using (SqlConnection ConexionBD = new SqlConnection(Conexion))
                {

                    ConexionBD.Open();

                    SqlCommand comando = new SqlCommand();

                    comando.CommandText = "SELECT IdNivelEscolaridad, Nombre FROM NivelEscolaridad";
                    comando.Connection = ConexionBD;

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Nescolar.Add(new NivelEscolaridad()
                            {
                                Id = Convert.ToInt32(reader["IdNivelEscolaridad"]),
                                Nombre = (string)reader["Nombre"]
                            });
                        }
                    }
                }

                cboNivelEscolaridad.DataSource = Nescolar;
                cboNivelEscolaridad.DisplayMember = "Nombre";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void LlenarComboEstadoCivil()
        {
            List<EstadoCivil> Ecivil = new List<EstadoCivil>();
            try
            {
                string Conexion = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
                using (SqlConnection ConexionBD = new SqlConnection(Conexion))
                {

                    ConexionBD.Open();

                    SqlCommand comando = new SqlCommand();

                    comando.CommandText = "SELECT IdEstadoCivil, Nombre FROM EstadoCivil";
                    comando.Connection = ConexionBD;

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Ecivil.Add(new EstadoCivil()
                            {
                                Id = Convert.ToInt32(reader["IdEstadoCivil"]),
                                Nombre = (string)reader["Nombre"]
                            });
                        }
                    }
                }

                cboEstadoCivil.DataSource = Ecivil;
                cboEstadoCivil.DisplayMember = "Nombre";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
    

        private void LLenarComboEps()
        {
            List<EPS> eps = new List<EPS>();
            try
            {
                string Conexion = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
                using (SqlConnection ConexionBD = new SqlConnection(Conexion))
                {

                    ConexionBD.Open();

                    SqlCommand comando = new SqlCommand();

                    comando.CommandText = "SELECT IdEps, Nombre FROM EPS";
                    comando.Connection = ConexionBD;

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            eps.Add(new EPS()
                            {
                                Id = Convert.ToInt32(reader["IdEps"]),
                                Nombre = (string)reader["Nombre"]
                            });
                        }
                    }
                }

                cboEPS.DataSource = eps;
                cboEPS.DisplayMember = "Nombre";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void LLenarComboTipoDocumento()
        {
            List<TipoDocumento> TDocumento = new List<TipoDocumento>();
            try
            {
                string Conexion = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
                using (SqlConnection ConexionBD = new SqlConnection(Conexion))
                {

                    ConexionBD.Open();

                    SqlCommand comando = new SqlCommand();

                    comando.CommandText = "SELECT IdTipoIdentificacion, Nombre FROM TipoIdentificacion";
                    comando.Connection = ConexionBD;

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TDocumento.Add(new TipoDocumento()
                            {
                                Id = Convert.ToInt32(reader["IdTipoIdentificacion"]),
                                Nombre = (string)reader["Nombre"]
                            });
                        }
                    }
                }

                cboTipoDocumento.DataSource = TDocumento;
                cboTipoDocumento.DisplayMember = "Nombre";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }


        }

        private void LlenarComboGenero()
        {
            List<Genero> genero = new List<Genero>();
            try
            {
                string Conexion = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
                using (SqlConnection ConexionBD = new SqlConnection(Conexion))
                {

                    ConexionBD.Open();

                    SqlCommand comando = new SqlCommand();

                    comando.CommandText = "SELECT IdSexo, Nombre FROM Sexo";
                    comando.Connection = ConexionBD;

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            genero.Add(new Genero()
                            {
                                Id = Convert.ToInt32(reader["IdSexo"]),
                                Nombre = (string)reader["Nombre"]
                            });
                        }
                    }
                }

                cboGenero.DataSource = genero;
                cboGenero.DisplayMember = "Nombre";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPrimerNombre.Clear();
            txtSegundoNombre.Clear();
            txtPrimerApellido.Clear();
            txtPrimerApellido.Clear();
            //cboTipoDocumento
            txtNumeroDocumento.Clear();
            //cboGenero.
            //dtpFechaNacimiento.
            txtEdad.Clear();
            //cboEstadoCivil.
            txtDireccion.Clear();
            txtBarrio.Clear();
            txtTelefono.Clear();
            txtOcupacion.Clear();
            //cboNivelEscolaridad.
            //cboEPS.
            //cboRegimen.
            txtCorreoElectronico.Clear();
            txtContactoEmergencia.Clear();
            txtAntecedentes.Clear();
        }

        private void txtNumeroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (char.IsNumber(e.KeyChar) ||                                 // Aqui solo acepta numeros
                          e.KeyChar == Convert.ToChar(Keys.Back) ||    // Tambien puedes aceptar teclas como BackSpace
                          e.KeyChar == Convert.ToChar(Keys.Delete)) ? false : true; // O tambien la tecla Delete
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (char.IsNumber(e.KeyChar) ||                                 // Aqui solo acepta numeros
                          e.KeyChar == Convert.ToChar(Keys.Back) ||    // Tambien puedes aceptar teclas como BackSpace
                          e.KeyChar == Convert.ToChar(Keys.Delete)) ? false : true; // O tambien la tecla Delete
        }

        
    }
}