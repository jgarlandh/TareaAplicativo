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
            #region
            //Persona p = new Persona();
            //p.RUTIdentificador = 168911955;
            //p.Nombre = "Jesus";
            //p.Apellidos = "Garland Herrera";
            //p.Edad = 25;
            //p.FechaDeNacimiento = DateTime.Parse("20/04/1993");
            //p.Sexo = 'M';

            //p.MostrarPersona();
            #endregion

            List<Persona> personasIngresadas = new List<Persona>();
            String input;
            int valorIngresado = 0;
            int comodin = 0;

            Console.WriteLine("Bienvenido a la consola de Personas");
            Console.WriteLine("");

            while (valorIngresado < 5)
            {
                Console.WriteLine("El aplicativo consta de las siguientes opciones:");
                Console.WriteLine("1. Añadir persona");
                Console.WriteLine("2. Eliminar persona");
                Console.WriteLine("3. Buscar persona");
                Console.WriteLine("4. Listar persona");
                Console.WriteLine("5. Salir");
                Console.WriteLine("Por favor, ingrese la opción seleccionada, digitando el número correspondiente");
                input = Console.ReadLine();

                comodin = int.Parse(input);

                if (comodin => 1 && comodin < 6)
                {
                    valorIngresado = comodin;

                    switch (valorIngresado)
                    {
                        case 1:

                            break;

                        case 2:
                            break;

                        case 3:
                            break;

                        case 4:
                            break;

                        case 5:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Los valores ingresados no corresponden a un valor entre 1 y 5");
                    Console.WriteLine("Por favor, intentelo nuevamente");
                }

            }

            








        }
    }
}
