using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectos
{
    class Programa_de_Facturas
    {
        static int PerToAv = 0; //Variable registro de la cantidad de personas totales que hicieron aventuras.
        static int MinHs = 0; //Variable donde se almacena la cantidad de horas de la aventura con menos horas incurridas.
        static string AvcMinhs; //Variable donde se almacena la aventura con menos horas incurridas.
        static void DataRec() //Clase donde se ingresan los datos de la factura.

        {

            int NPaquete; //Ingreso de Número del paquete y validacion del dato.
            while (true)
            {

                Console.WriteLine("Ingrese él Número del paquete:");

                string Ingreso = Console.ReadLine();

                if (int.TryParse(Ingreso, out NPaquete)) //Validación del int.
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Entrada inválida, ingrese un número.");
                }

            }

            int PerInc; //Ingreso del Número de Personas Incluidas.
            while (true)
            {

                Console.WriteLine("Ingrese la Cantidad de personas Incluidas:");

                string Ingreso = Console.ReadLine();

                if (int.TryParse(Ingreso, out PerInc)) //Validación del int.
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Entrada inválida, ingrese un número.");
                }
            }

            int PxP; //Ingreso del Número de precio por persona.
            while (true)
            {

                Console.WriteLine("Ingrese el Precio por Persona:");

                string Ingreso = Console.ReadLine();

                if (int.TryParse(Ingreso, out PxP)) //Validación del int.
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Entrada inválida, ingrese un número.");
                }
            }

            int HsT; //Ingreso del Número de Horas Totales.
            while (true)
            {
                Console.WriteLine("Ingrese las Horas totales registradas:");

                string Ingreso = Console.ReadLine();

                if (int.TryParse(Ingreso, out HsT)) //Validación del int.
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Entrada inválida, ingrese un número.");
                }
            }

            string AdvType; // Variable de

            while (true) //Entrada y validación de tipo de aventura. 
            {
                Console.WriteLine("Ingrese una aventura (M, T, R, B, C, E, K, S, J, P):");
                AdvType = Console.ReadLine();  // Leer nueva entrada del usuario

                if (AdvType is string)
                {
                    switch (AdvType)
                    {
                        case "M":
                            Console.WriteLine("Montaña");
                            Console.Clear();
                            AvcMinhs = "Montaña";
                            break;
                        case "T":
                            Console.WriteLine("Trekking");
                            Console.Clear();
                            AvcMinhs = "Trekking";
                            break;
                        case "R":
                            Console.WriteLine("Rafting");
                            Console.Clear();
                            AvcMinhs = "Rafting";
                            break;
                        case "B":
                            Console.WriteLine("Bicicleta");
                            Console.Clear();
                            AvcMinhs = "Bicicleta";
                            break;
                        case "C":
                            Console.WriteLine("Canopy");
                            Console.Clear();
                            AvcMinhs = "Canopy";
                            break;
                        case "E":
                            Console.WriteLine("Escalar");
                            Console.Clear();
                            AvcMinhs = "Escalar";
                            break;
                        case "K":
                            Console.WriteLine("Sky");
                            Console.Clear();
                            AvcMinhs = "Sky";
                            break;
                        case "S":
                            Console.WriteLine("Snowboard");
                            Console.Clear();
                            AvcMinhs = "Snowboard";
                            break;
                        case "J":
                            Console.WriteLine("Jumping");
                            Console.Clear();
                            AvcMinhs = "Jumping";
                            break;
                        case "P":
                            Console.WriteLine("Parapente");
                            Console.Clear();
                            AvcMinhs = "Parapente";
                            break;
                        default:
                            Console.WriteLine("Ingrese una aventura válida");
                            continue;
                    }
                    Console.Clear();
                    break;
                }
                else
                { Console.WriteLine("Entrada inválida. Por favor ingrese una aventura válida"); } //Caso tipo inválido

            }
        }
        static void ProcesamientoDeDatos() 
        {
            while (NPaquete != 0)
            { }
        }
        static void MostrarResultadosMinimosAv()
        {
            Console.WriteLine("La Aventura con menos horas incurridas fue: " + AvcMinhs); //Aventura con menos Horas incurridas.
            Console.WriteLine("La cantidad de horas incurridas fueron de: " + MinHs); //Cantidad de Horas de la aventura con menos horas incurridas.
        }
        
        static void Main(string[] args) //Programa principal.
        {
            Console.WriteLine("Presione la tecla 'ENTER' para Ingresar datos del paquete");
            Console.ReadLine();
            Console.Clear();
            DataRec();//Funcion de ingreso de datos.
            ProcesamientoDeDatos();
            MostrarResultadosMinimosAv();//Funcion de Mínimo de Horas en una Aventura.
                
            Console.ReadKey();
        }
    }
}

