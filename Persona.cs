using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaSeba
{
    public class Persona
    {
        public Persona()
        {
            RUTIdentificador = "";
            Nombre = "";
            Apellidos = "";
            Edad = "";
            FechaDeNacimiento = "";
            Sexo = "";
        }

        public string RUTIdentificador { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Edad { get; set; }
        public string FechaDeNacimiento { get; set; }
        public string Sexo { get; set; }
    }
}
