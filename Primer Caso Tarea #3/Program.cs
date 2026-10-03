using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_Caso_Tarea__3
{
    internal class Program
    {

        //Tarea #3 Joxan Vivas Porras
        // Casos elegidos: Caso 3 Conversión de temperatura y Caso 5 Control de inventario


        //Caso 5 Control de inventario
        static void controlInventario()
        {
            int disponible = 0;
            int venta = 0;
            int restante = 0;

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("---------------Control de inventario---------------");
            Console.WriteLine("Ingrese el inventario disponible: ");
            disponible = int.TryParse(Console.ReadLine(), out disponible) ? disponible : -1; // hace que si no puede ser convertido a int , sea un nuero invalido, en este caso -1.
            Console.WriteLine("Ingrese la cantidad que desea vender: ");
            venta = int.TryParse(Console.ReadLine(), out venta) ? venta : -1; // hace que si no puede ser convertido a int , sea un nuero invalido, en este caso -1.
            Console.ResetColor();
            if ((disponible >= venta) && (venta > 0 && disponible > 0)) //Valida que las opciones no sean negativas y que la venta no sea mayor al inventario disponible.
            {
                restante = disponible - venta;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Se puede realizar la venta");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("El inventario restante es: " + restante);
                Console.ResetColor();
            }
            else
            {
              
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No se puede realizar la venta");
                Console.ResetColor();
            }

        }
        //Caso 3 Conversión de temperatura
        static void conversionTemperatura()
        {
            double celsius = 0.0;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("---------------Conversión de temperatura---------------");
            Console.WriteLine("Ingrese los grados en celsius: ");
            bool Valido = double.TryParse(Console.ReadLine(), out celsius); //Bool hace que, si se puede convertir a double, es true , si no, es false.
            Console.ResetColor();
            if (!Valido) //vaida si el bool es false, si es asi, entonces no se pudo convertir a double, por lo tanto, es un dato inválido.
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Datos inválidos, ingrese solo números");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                double farenheid = (celsius * 1.8) + 32;
                Console.WriteLine($"Los grados en farenheid son: {farenheid}°F");
                Console.ResetColor();
            }
        }
        //Menu para elegir entre los dos casos
        static void menu()
        {
            int opcion = 0;

           
            do
            {
                Console.Clear();
                Console.WriteLine("---------------Menu de casos---------------");
                Console.WriteLine("1. Conversión de temperatura");
                Console.WriteLine("2. Control de inventario");
                Console.WriteLine("3. Salir");
                Console.WriteLine("Ingrese la opción que desea ejecutar (1-3): ");
                opcion = int.TryParse(Console.ReadLine(), out opcion) ? opcion : 0;

                switch (opcion)
                {
                    case 1:
                        conversionTemperatura();
                        break;
                    case 2:
                        controlInventario();
                        break;
                    case 3:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }
                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();
            } while (opcion != 3);
        }
        static void Main(string[] args)
        {
            menu();
        }
    }
}
