using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectos
{
    class Programa_de_Facturas
    {
        static int HsT; //Variable de la cantidad de horas totales.
        static int PxP; //Variable del precio de la aventura por persona. 
        static int PerInc; //Variable de la cantidad de personas incluidas.
        static string AdvType; // Variable de tipo de aventura.
        static int NPaquete; // Variable del número de paquete.
        static int PerToAv = 0; //Variable registro de la cantidad de personas totales que hicieron aventuras.
        static int MinHs = 0; //Variable donde se almacena la cantidad de horas de la aventura con menos horas incurridas.
        static string AdvConMinHsT; //Variable donde se almacena la aventura con menos horas incurridas.
        static void DataRec() //Clase donde se ingresan los datos de la factura.

        {

             //Ingreso de Número del paquete y validacion del dato.
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

            if (NPaquete == 0) //Cierre del programa al ingresar 0.
            {
                Console.WriteLine("Ingresos finalizados.");
                Console.ReadLine();
                return;
            }

            while (true) //Ingreso del Número de Personas Incluidas.
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
            if (PerInc == 0) //Verificación de venta de paquete de aventura. 
            {
                Console.WriteLine("Se ha ingresado una aventura sin ventas. Por favor ingrese una aventura que se haya vendido al público.");
                return;
            }
                while (true) //Ingreso del Número de precio por persona.
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

            
            while (true)//Ingreso del Número de Horas Totales.
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
                            
                            break;
                        case "T":
                            Console.WriteLine("Trekking");
                            Console.Clear();
                            
                            break;
                        case "R":
                            Console.WriteLine("Rafting");
                            Console.Clear();
                            
                            break;
                        case "B":
                            Console.WriteLine("Bicicleta");
                            Console.Clear();
                            
                            break;
                        case "C":
                            Console.WriteLine("Canopy");
                            Console.Clear();
                            
                            break;
                        case "E":
                            Console.WriteLine("Escalar");
                            Console.Clear();
                            
                            break;
                        case "K":
                            Console.WriteLine("Sky");
                            Console.Clear();
                            
                            break;
                        case "S":
                            Console.WriteLine("Snowboard");
                            Console.Clear();
                            
                            break;
                        case "J":
                            Console.WriteLine("Jumping");
                            Console.Clear();
                           
                            break;
                        case "P":
                            Console.WriteLine("Parapente");
                            Console.Clear();
                           
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
            {
                String TipoAdvActual = AdvType;
                int MaxVenta = 0;
                int PaquetesVendidos = 0;

                void MostrarMaxYPaquetesV()
                {
                    Console.WriteLine("Se vendieron un total de: " + PaquetesVendidos + " Paquetes la anterior aventura.");
                    Console.WriteLine("La venta que más recaudó fue de: $" + MaxVenta);
                    Console.ReadLine();
                }

                while (TipoAdvActual == AdvType) 
                {
                        PaquetesVendidos++;
                        PerToAv =+ PerInc; //PROBLEMA
                        int TotalRecaudado = PxP * PerInc;
                        if (TotalRecaudado > MaxVenta)
                        {
                            MaxVenta = TotalRecaudado;
                        }
                        if (MinHs < HsT) //Horas Minimas.PROBLEMA
                        {
                            MinHs = HsT;
                            AdvConMinHsT = AdvType;
                        }
                        DataRec();
                 }
                MostrarMaxYPaquetesV();
            }
        }       
        static void MostrarResultadosMinimosAv()
        {
            Console.WriteLine("La Aventura con menos horas incurridas fue: " + AdvConMinHsT); //Aventura con menos Horas incurridas.
            Console.WriteLine("La cantidad de horas incurridas fueron de: " + MinHs); //Cantidad de Horas de la aventura con menos horas incurridas.
        }
        static void MostrarPersonasTo() //Funcion de personas totales.
        {
            Console.WriteLine(PerToAv + " Disfrutaron de Aventuras esta temporada.");
            
        }
        static void Main(string[] args) //Programa principal.
        {
            Console.WriteLine("Presione la tecla 'ENTER' para Ingresar datos del paquete");
            Console.ReadLine();
            Console.Clear();
            DataRec();//Funcion de ingreso de datos.
            ProcesamientoDeDatos();
            MostrarResultadosMinimosAv();//Funcion de Mínimo de Horas en una Aventura.
            MostrarPersonasTo(); //Funcion de personas totales.
            
            
            Console.ReadKey();
        }
    }
}

