using System;

namespace misprogramas
{
    class Primero 
    {
        static void Main(string[] args)
        {
            // Nombre del estudiante
            
            Console.WriteLine("Nombre: Jose Delio Gonzales Aracena");
            Console.WriteLine("Matricula: 17-EIIN-1-108");
            Console.WriteLine();

            int nota;

            while (true) {
                Console.Write("Por favor introduzca una nota entre 0 y 100: ");
                nota = int.Parse(Console.ReadLine());

                if (nota < 0) {
                    Console.WriteLine("La nota no puede ser menor que cero");
                    continue; // vuelve a pedir la nota
                }

                if (nota > 100) {
                    Console.WriteLine("La nota no puede ser mayor que cien");
                    continue; // vuelve a pedir la nota
                }
                break; // sal del bucle si ya tienes una nota entre 0 y 100
            }
            
            if (nota >= 90) {
                Console.WriteLine("Usted tiene una A");
            } else if (nota >= 80) {
                Console.WriteLine("Usted tiene una B");
            } else if (nota >= 70) {
                Console.WriteLine("Usted tiene una C");
            } else {
                Console.WriteLine("Usted no pudo aprobar la materia. Su calificacion final es: {0}", nota);
            }
        }
    }
}
