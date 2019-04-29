using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sucursal
    {
        
        public static string[] Id = new string[] { "C1", "C2", "C3" };
        public static string[] Ciudad = new string[] { "Medellin", "Monteria", "Bogota" };
        public static string[] Direccion = new string[] { "Cra 48 N26 A 50, Medellín, Antioquia", "Cra 48 N26 A 50, Monteria, Cordoba", "Cra 48 N26 A 50, Bogota, DC" }; // escribo prop y doble tabulacion
        public static string[] Telefono = new string[] { " (4) 4486115", " (4) 4486116", " (4) 4486117" };
        public static string[] Email = new string[] { "labmehermanoscampuzano@gmail.com", "labmohermanoscampuzano@gmail.com", "labbohermanoscampuzano@gmail.com" };
        public static string[] HorarioEntregaResultadosSemana = new string[] { " 7:00 a. m. a 10:00 p. m. ", " 7:00 a. m. a 10:00 p. m. ", " 7:00 a. m. a 10:00 p. m. " };
        public static string[] HorarioEntregaResultadosFinSemana = new string[] { "7:00 a. m. a 12:00 m. ", "7:00 a. m. a 12:00 m. ", "7:00 a. m. a 12:00 m. " };
        public static string[] HorarioTomaMuestraSemana = new string[] { " 6:30 a. m. a 8:00 a. m.", " 6:30 a. m. a 8:00 a. m.", " 6:30 a. m. a 8:00 a. m." };
        public static string[] HorarioTomaMuestraFinSemana = new string[] { " 6:30 a. m. a 8:00 p. m.", " 6:30 a. m. a 8:00 p. m.", " 6:30 a. m. a 8:00 p. m." };

        public static int n = 2;

    }
}
