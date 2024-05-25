using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeAccseso
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("Elige unas de las opciones");
                Console.WriteLine("1. sin vehiculo valor $100");
                Console.WriteLine("2. moto valor $800");
                Console.WriteLine("3. auto valor $1000");
                Console.WriteLine("4. camioneta valor $1500");
                Console.WriteLine("5. bugy valor $5000");
                Console.WriteLine("6. vehiculo nauticovalor $1200");
                Console.WriteLine("7. salir");
                int opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("has elegido la opcion 1 'sin vehiculo' ");
                        break;
                    case 2:
                        Console.WriteLine("has elegido la opcion 2 'moto' ");
                        break;
                    case 3:
                        Console.WriteLine("has elegido la opcion 3 'auto' ");
                        break;
                    case 4:
                        Console.WriteLine("has elegido la opcion 4 'camioneta' ");
                        break;
                    case 5:
                        Console.WriteLine("has elegido la opcion 5 'bugy' ");
                        break;
                    case 6:
                        Console.WriteLine("has elegido la opcion 6 'vehiculo nautico' ");
                        break;
                    case 7:
                        Console.WriteLine("salir");
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                        break;
                      

                }
              Console.ReadKey();
                while (!salir)
                {
                    Console.WriteLine("Cuantos dias desea quedarse, elija una opcion, se aplicara un porcentaje para el costo final");
                    Console.WriteLine("1. Un dia porcentaje:100%");
                    Console.WriteLine("2. Dos dias porcentaje:120%");
                    Console.WriteLine("3. Tres dias porcentaje:220%");
                    Console.WriteLine("4. Cuatro dias porcentaje:320%");
                    Console.WriteLine("5. Entre cinco y diez dias porcentaje:380%");
                    Console.WriteLine("6. salir");
                    Console.WriteLine("aplicaremos impuestos del 21% del IVA y un 15% para salvar a los peces de la cima del aconcagua");
                    int opcionn = Convert.ToInt32(Console.ReadLine());
                     switch (opcionn)
                     {
                         case 1: Console.WriteLine("Has elegido quedarte 1 dia!");
                            break;
                         case 2: Console.WriteLine("Has elegido quedarte 2 dias!");
                            break;
                         case 3: Console.WriteLine("Has elegido quedarte 3 dias!");
                            break;
                         case 4: Console.WriteLine("Has elegido quedarte 4 dias!");
                            break; 
                         case 5: Console.WriteLine("Has elegido quedarte entre 5 y 10 dias!");
                            break;
                         case 6:Console.WriteLine("salir");
                            salir = true;
                            break;
                         default:
                            Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                            break;
                    }
                    Console.ReadKey ();

                }



            }
        }
    }
}