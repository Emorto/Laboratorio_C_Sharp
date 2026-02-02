using Laboratorio_C_Sharp.Temas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("=== PORTAFOLIO DE APRENDIZAJE C# ===");
                Console.WriteLine("1. Estructuras Condicionales (If/Else)");
                Console.WriteLine("2. Ciclos (While/For)");
                Console.WriteLine("0. Salir");
                Console.Write("\nSelecciona un tema para probar: ");
                string opcion = Console.ReadLine();
               
                    switch (opcion)
                    {
                        case "1":
                            Condicionales.Ejecutar(); // Llamada a la clase externa
                            break;
                        case "2":
                            // Ciclos.Ejecutar(); 
                            break;
                        case "0":
                            continuar = false;
                            break;
                        default:
                            Console.WriteLine("Opción inválida.");
                            break;
                    }
                

                if (continuar)
                {
                    Console.WriteLine("\nPresiona cualquier tecla para volver al menú...");
                    Console.ReadKey();
                }
            }
        }
        
    }
}
