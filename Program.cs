using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaSeba
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona();
            p.RUTIdentificador = 168911955;
            p.Nombre = "Jesus";
            p.Apellidos = "Garland Herrera";
            p.Edad = 25;
            p.FechaDeNacimiento = DateTime.Parse("20/04/1993");
            p.Sexo = 'M';

            p.MostrarPersona();
        }
    }
}
