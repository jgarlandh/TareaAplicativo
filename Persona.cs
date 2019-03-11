using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaSeba
{
    public class Persona
    {
        #region
        //    String RUTIdentificador;
        //    Nombre = "";
        //    Apellidos = "";
        //    Edad = "";
        //    FechaDeNacimiento = "";
        //    Sexo = "";

        //public Persona()
        //{
        //    //RUTIdentificador = "";
        //    //Nombre = "";
        //    //Apellidos = "";
        //    //Edad = "";
        //    //FechaDeNacimiento = "";
        //    //Sexo = "";
        //}
        #endregion
        public string RUTIdentificador { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public char Sexo { get; set; }
        public string Nacionalidad { get; set; }

        public override string ToString()
        {
            return "RUT: " + RUTIdentificador + "\n" +
                "Nombre: " + Nombre + " " + Apellidos + "\n" +
                "Edad: " + (DateTime.Today.Year - (FechaDeNacimiento.Year)) + "\n" +
                "Fecha de Nacimiento: " + FechaDeNacimiento.ToShortDateString() + "\n" +
                "Sexo: " + Sexo + "\n" + "Nacionalidad: " + Nacionalidad + "\n";
        }

    }
}
