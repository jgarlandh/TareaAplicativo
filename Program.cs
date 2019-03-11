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
            Persona p = new Persona();
            p.RUTIdentificador = "168911955";
            p.Nombre = "Jesus";
            p.Apellidos = "Garland Herrera";
            p.Edad = 25;
            p.FechaDeNacimiento = DateTime.Parse("20/04/1993");
            p.Sexo = 'M';

            Console.WriteLine(p.ToString());

            Imprimir imp = new Imprimir(p);
            imp.imprimirPersona();
            #endregion

            List<Persona> personas = new List<Persona>();
            int valorIngresado = 0;

            Console.WriteLine("Bienvenido a la consola de Personas");
            Console.WriteLine("");

            while (valorIngresado < 5)
            {

                try
                {

                    Console.WriteLine("El aplicativo consta de las siguientes opciones:");
                    Console.WriteLine("1. Añadir persona");
                    Console.WriteLine("2. Eliminar persona");
                    Console.WriteLine("3. Buscar persona");
                    Console.WriteLine("4. Listar persona");
                    Console.WriteLine("5. Salir");
                    Console.WriteLine("Por favor, ingrese la opción seleccionada, digitando el número correspondiente");
                    valorIngresado = int.Parse(Console.ReadLine());

                    if (valorIngresado >= 1 && valorIngresado < 6)
                    {
                        switch (valorIngresado)
                        {
                            case 1:

                                Console.WriteLine("");
                                Console.WriteLine("Ha seleccionado la opción:");
                                Console.WriteLine("1. Añadir persona");
                                Console.WriteLine("");

                                break;

                            case 2:

                                Console.WriteLine("");
                                Console.WriteLine("Ha seleccionado la opción:");
                                Console.WriteLine("2. Eliminar persona");
                                Console.WriteLine("");

                                break;

                            case 3:

                                Console.WriteLine("");
                                Console.WriteLine("Ha seleccionado la opción:");
                                Console.WriteLine("3. Buscar persona");
                                Console.WriteLine("");

                                Console.WriteLine("");
                                Console.WriteLine("Por favor, ingrese el RUT de la persona a buscar");
                                //personasIngresadas.Find(x => x.RUTIdentificador == Console.ReadLine()).MostrarPersona;


                                //Console.WriteLine("\nFind: Part where name contains \"seat\": {0}",
                                //parts.Find(x => x.PartName.Contains("seat")));

                                break;

                            case 4:

                                Console.WriteLine("");
                                Console.WriteLine("Ha seleccionado la opción:");
                                Console.WriteLine("4. Listar persona");
                                Console.WriteLine("");

                                break;

                            case 5:

                                Console.WriteLine("");
                                Console.WriteLine("Ha seleccionado la opción:");
                                Console.WriteLine("5. Salir");
                                Console.WriteLine("");

                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Los valores ingresados no corresponden a un valor entre 1 y 5");
                        Console.WriteLine("Por favor, intentelo nuevamente");
                    }


                }
                catch (FormatException)
                {
                    Console.WriteLine("Los valores ingresados no corresponden a un valor entre 1 y 5");
                    Console.WriteLine("Por favor, intentelo nuevamente");
                }

            }

        }
    }
}
