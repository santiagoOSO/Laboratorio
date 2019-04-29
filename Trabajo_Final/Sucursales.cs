using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sucursales
{
    public partial class FSucursales : Form
    {
        public FSucursales()
        {
            InitializeComponent();

        }
        
        //Crear valores para inicializar objetos Sucursal.


        string[] Ciudad = Sucursal.Ciudad;
        string[] Direccion = Sucursal.Direccion;
        string[] Telefono = Sucursal.Telefono;
        string[] Email = Sucursal.Email;
        string[] HorarioEntregaResultadosSemana = Sucursal.HorarioEntregaResultadosSemana;
        string[] HorarioEntregaResultadosFinSemana = Sucursal.HorarioEntregaResultadosFinSemana;
        string[] HorarioTomaMuestraSemana = Sucursal.HorarioTomaMuestraSemana;
        string[] HorarioTomaMuestraFinSemana = Sucursal.HorarioTomaMuestraFinSemana;

        int n = Sucursal.n;

        private void Sucursales_Load(object sender, EventArgs e)
        {
            ltbCiudad.Items.Add("Medellin");
            ltbCiudad.Items.Add("Monteria");
            ltbCiudad.Items.Add("Bogota");
        }

        private void ltbCiudad_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
            string ciudad = Convert.ToString(ltbCiudad.SelectedIndex);

            for (int p = 0; p <= n; p++)
            {
                if (ltbCiudad.Text == Ciudad[p])
                {
                    dgvSucursal.Rows.Add(Ciudad[p], Direccion[p], Telefono[p], Email[p], HorarioEntregaResultadosSemana[p], HorarioEntregaResultadosFinSemana[p], HorarioTomaMuestraSemana[p], HorarioTomaMuestraFinSemana[p]);
                    ltbCiudad.ClearSelected();
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            dgvSucursal.Rows.Clear();
        }


        }


    }

