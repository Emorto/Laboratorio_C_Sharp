using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_C_Sharp.Temas
{
    public static class Condicionales
    {
        /// <summary>
        /// Método para ejecutar el tema de estructuras condicionales.
        /// </summary>
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("=== TEMA: ESTRUCTURAS CONDICIONALES ===");
            Console.Write("Introduce la nota del alumno: ");

            if (double.TryParse(Console.ReadLine(), out double nota))
            {
                string resultado = (nota >= 7) ? "Aprobado" : "Suspenso";
                Console.WriteLine($"Resultado: {resultado}");
            }
            else
            {
                Console.WriteLine("Entrada no válida.");
            }
        }
    }
}
