using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectos
{
    class Programa_de_Facturas
    {
        static void DataRec()
        {
            Console.WriteLine("Ingrese Numero de paquete");
            int PkgN = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese Cantidad de personas Incluidas");
            int PplInc = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese Precio por Persona");
            int PriceForPpl = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese Horas totales registradas");
            int THours = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la inicial del tipo de aventura (mayuscula)");
            string AdvType = Console.ReadLine();
            switch (AdvType)
            {
                case "M":
                    Console.WriteLine("Montaña");
                    break;
                case "T":
                    Console.WriteLine("Trekking");
                    break;
                case "R":
                    Console.WriteLine("Rafting");
                    break;
                case "B":
                    Console.WriteLine("Bicicleta");
                    break;
                case "C":
                    Console.WriteLine("Canopy");
                    break;
                case "E":
                    Console.WriteLine("Escalar");
                    break;
                case "K":
                    Console.WriteLine("Sky");
                    break;
                case "S":
                    Console.WriteLine("Snowboard");
                    break;
                case "J":
                    Console.WriteLine("Jumping");
                    break;
                case "P":
                    Console.WriteLine("Parapente");
                    break;
                default:
                    Console.WriteLine("Ingrese una aventura valida");
                    break;
            }
            Console.ReadKey();


        }    
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese datos del paquete");
            Console.ReadLine();
            Console.Clear();
            DataRec();
            Console.ReadKey();
        }
    }
}
