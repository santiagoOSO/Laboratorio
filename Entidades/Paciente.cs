using System;

namespace Entidades
{

    public class Paciente
    {
            
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public Genero Genero { get; set; }
        public DateTime FechaNacimiento { get; set; }
        //EDAD
        public EstadoCivil EstadoCivil { get; set; }
        public string Direccion { get; set; }
        public string Barrio { get; set; }
        public string Telefono { get; set; }
        public string Ocupacion { get; set; }
        public NivelEscolaridad NivelEscolaridad { get; set; }
        public EPS EPS { get; set; }
        public Regimen Regimen { get; set; }
        public string CorreoElectronico { get; set; }
        public string NombreTipoDocumento
        {
            get
            {
                if(TipoDocumento != null)
                {
                    return TipoDocumento.Nombre;
                }
                return string.Empty;
            }
        }
            
    }
}
