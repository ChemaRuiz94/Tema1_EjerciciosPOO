using System;

namespace Tema1_EjerciciosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EJERCICIOS TEMA 1 - CHEMA RUIZ");
            int op;
            do {
                Console.WriteLine("______________________________");
                Console.WriteLine("1 -> Manejar Fechas");
                Console.WriteLine("2 -> Clase Libros");
                Console.WriteLine("3 -> Alquiler Puerto");
                Console.WriteLine("4 -> Salir");
                Console.WriteLine("Escoge una opcion: ");
                Console.WriteLine("______________________________");

                op = (int)Console.Read();

                if (op >= 0 && op <= 4)
                {
                    //Aqui va el menú
                }
                else 
                {
                    Console.WriteLine("Introduce una opcion correcta")
                };
            } while (op == 4);

        }
    }
}
