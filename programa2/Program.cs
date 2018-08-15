using System;

namespace misprogramas
{
    class Programa
    {
        static void Main(string[] args)
        {
            // Este programa muestra todos los numeros impares entre 0 y un numero elegido por el usuario
            
            // Nombre del estudiante
            
            Console.WriteLine("Nombre: ");
            Console.WriteLine("Matricula: ");
            Console.WriteLine();

            int numero;

            int intentos = 1;

            while (true) {
                Console.Write("Por favor un numero mayor que cero: ");
                numero = int.Parse(Console.ReadLine());

                if (numero < 0) {
                    Console.WriteLine("El numero no puede ser menor que cero");
                    continue; // vuelve a pedir la nota
                }
                
                if (intentos > 3) { 
                    Console.WriteLine("Usted agoto todos los intentos para introducir un numero menor que cero");
                    Environment.Exit(1); // Salir del programa
                }

                break; // sal del bucle si ya tienes una nota entre 0 y 100
            }
            
            for (int i = 1; i <= numero; i = i + 2) {
                Console.WriteLine(i);
            }
        }
    }
}
