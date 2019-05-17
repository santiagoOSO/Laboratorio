using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Trabajo_Final
{
    // Link de explicacion de conexion de la base de datos. https://www.youtube.com/watch?v=ZuHTkTDxNI0



     class Conexion
    {/*
         private  SqlConnection conex = new SqlConnection("Data source = SALA235-PC12\\SQLEXPRESS; Initial Catolog= LaboratorioMedico; User Id=sa; Password= fnsp ");
         private DataSet ds;

         public bool Insertar( int NumeroIdentificacion, string PrimerNombre, string SegundoNombre, string PrimerApellido, string SegundoApellido, string IdSexo, string FechaNacimiento, string Edad, string IdEstadoCivil, string Direccion, string Barrio, string Telefono, string Ocupacion, string IdNivelEscolaridad, string IdEps, string IdRegimen, string Email, string ContactoCasoEmergencia)
         {
             conex.Open();
             SqlCommand cmd = new SqlCommand(string.Format("insert into Paciente values {0}, '{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}'", new string[] {Convert.ToString (NumeroIdentificacion), PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, IdSexo, FechaNacimiento, Edad, IdEstadoCivil, Direccion, Barrio, Telefono, Ocupacion, IdNivelEscolaridad, IdEps, IdRegimen, Email, ContactoCasoEmergencia }),conex);
             int filasAceptadas = cmd.ExecuteNonQuery();
             conex.Close();
             if (filasAceptadas > 0) return true;
             else return false;
         
         
         
         }





         */




            /*
            SqlConnection cn;
            SqlCommand cmd;
            SqlDataReader dr;

            public Conexion()
            {
                try
                {
                    cn = new SqlConnection ("Data Source=SALA235-PC12\\SQLEXPRESS;Initial Catalog=Laboratorio;Persist Security Info=True;User ID=sa;Password=fnsp");
                    cn.Open();
                    MessageBox.Show("Conectado");
                }

                catch( Exception ex)
                {
                    MessageBox.Show("No se conectó con la base de datos: "+ ex.ToString());
                }
            
            }

            public string Insertar(string PrimerNombre, string SegundoNombre, string PrimerApellido, string SegundoApellido, int NumeroDocuemtno )
        {

            string Salida = "Si se insertó";
            try
            {
                cmd = new SqlCommand(" Insert Into Paciente(PrimerNombre,SegundoNombre,PrimerApellido,SegundoApellido,TipoDocuemnto,NumeroDocuemnto) values ( '" + PrimerNombre + "','" + SegundoApellido + "', '" + PrimerApellido + "', '" + SegundoApellido + "', " + NumeroDocuemtno + ")", cn  );
                cmd.ExecuteNonQuery();
            }


            catch ( Exception ex)
            {
               Salida = " No se conectó: " + ex.ToString();

           }

            return Salida;
        }

            public int PersonaRegistrada(int NumeroDocuemnto  )
        {

            int contador = 0;

            try
            {
                cmd = new SqlCommand(" Select * from Paciente where NumeroDocumento=  " + NumeroDocuemnto + "", cn  );
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    contador++;
                }
            }
            catch ( Exception ex)
            {
               MessageBox.Show( " El paciente ya está registrado" + ex.ToString());

           }
            return contador;



            }*/





        



    }

}