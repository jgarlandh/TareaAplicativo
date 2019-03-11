using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaSeba
{
    public class Imprimir
    {
        Persona persona;

        public Imprimir(Persona persona)
        {
            this.persona = persona;
        }

        public void mostrarRUT()
        {
            Console.WriteLine("RUT: " + this.persona.RUTIdentificador);
        }

        public void mostrarNombre()
        {
            Console.WriteLine("Nombre: " + this.persona.Nombre + " " + this.persona.Apellidos);
        }

        public void mostrarEdad()
        {
            Console.WriteLine("Edad: " + (DateTime.Today.Year - (this.persona.FechaDeNacimiento.Year)) + " años");
        }

        public void mostrarFechaDeNacimiento()
        {
            Console.WriteLine("Fecha de Nacimiento: " + this.persona.FechaDeNacimiento.ToShortDateString());
        }

        public void mostrarSexo()
        {
            if (this.persona.Sexo == 'M')
            {
                Console.WriteLine("Sexo: " + this.persona.Sexo + "asculino");
            }
            else
            {
                Console.WriteLine("Sexo: " + this.persona.Sexo + "emenino");
            }
        }

        public void mostrarNacionalidad()
        {
            Console.WriteLine("Nacionalidad: " + this.persona.Nacionalidad);
        }

        public void imprimirPersona()
        {
            Console.WriteLine("\n");
            mostrarRUT();
            this.mostrarNombre();
            this.mostrarEdad();
            this.mostrarFechaDeNacimiento();
            this.mostrarSexo();
            this.mostrarNacionalidad();
            Console.WriteLine("\n");
        }

    }
}
