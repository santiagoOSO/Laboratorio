using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Entidades;

namespace Trabajo_Final
{
    public partial class Paciente : Form
    {
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
                Genero = new Genero()
                {
                    Nombre = cboGenero.SelectedItem as string
                },
                FechaNacimiento = dtpFechaNacimiento.Value,
                EstadoCivil =  new EstadoCivil
                {
                    Nombre = cboEstadoCivil.SelectedItem as string
                },
                Direccion = txtDireccion.Text,
                Barrio = txtBarrio.Text,
                Telefono = txtTelefono.Text,
                Ocupacion = txtOcupacion.Text,
                NivelEscolaridad =  new NivelEscolaridad()
                {
                    Nombre = cboNivelEscolaridad.SelectedItem as string
                },
                EPS = new EPS()
                {
                    Nombre = cboEPS.SelectedItem as string
                },
                Regimen = new Regimen()
                {
                    Nombre = cboRegimen.SelectedItem as string
                },
                
                CorreoElectronico = txtCorreoElectronico.Text,
                

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

            /*/SEGUNDO NOMBRE
            if (string.IsNullOrEmpty(txtSegundoNombre.Text.Trim()))
            {
                erpMensaje.SetError(txtSegundoNombre, "Por favor ingrese el Segundo Nombre");
                return false;
            }
            else
            {
                erpMensaje.SetError(txtSegundoNombre, null);
            }
            */

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

            /*/SEGUNDO APELLIDO
            if (string.IsNullOrEmpty(txtSegundoApellido.Text.Trim()))
            {
                erpMensaje.SetError(txtSegundoApellido, "Por favor ingrese el Segundo apellido");
                return false;
            }
            else
            {
                erpMensaje.SetError(txtSegundoApellido, null);
            }
            */

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

            /*/TELEFONO
            if (string.IsNullOrEmpty(txtTelefono.Text.Trim()))
            {
                erpMensaje.SetError(txtTelefono, "Por favor ingrese el teléfono");
                return false;
            }
            else
            {
                erpMensaje.SetError(txtTelefono, null);
            }
            */

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

            /*/CORREO ELECTRONICO
            if (string.IsNullOrEmpty(txtCorreoElectronico.Text.Trim()))
            {
                erpMensaje.SetError(txtCorreoElectronico, "Por favor ingrese el correo electrónico");
                return false;
            }
            else
            {
                erpMensaje.SetError(txtCorreoElectronico, null);
            }
            */

            return true;
        }

        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {







        }

        private void Paciente_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
