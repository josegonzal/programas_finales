using System;

namespace programa3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Este programa imprime la tabla de multiplicacion entre 1 y 12
             
            Console.WriteLine("Nombre: ");
            Console.WriteLine("Matricula: ");
            Console.WriteLine();
        
            Console.Write("Por favor elija un numero entre 1 y 12: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero <= 0) {
                Console.WriteLine("El numero no puede ser menor que cero.");
                Environment.Exit(1);
            }

            if (numero > 12) {
                Console.WriteLine("El numero no puede ser mayor que doce.");
                Environment.Exit(1);
            }

            for (int i = 1; i <= 12; i++) {
                Console.WriteLine("{0} x {1} = {2}", numero, i, numero * i);
            }
            Console.WriteLine("Adios!");
        }
    }
}
