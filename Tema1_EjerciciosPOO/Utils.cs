using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1_EjerciciosPOO
{
    class Utils
    {
        public Utils() { }

        /*
         * Para pintar el Menu principal
         */
        public void pintarMenu()
        {
            Console.WriteLine("______________________________");
            Console.WriteLine("1 -> Manejar Fechas");
            Console.WriteLine("2 -> Clase Libros");
            Console.WriteLine("3 -> Alquiler Puerto");
            Console.WriteLine("4 -> Salir");
            Console.WriteLine("______________________________");
        }

        /**
         * Para pedir un numero al usuario
         * y asegurarnos que introduce un entero
         */
        public int pedirNum(String st)
        {
            bool valido;
            int num;
            do
            {
                Console.Write("\n " + st);
                valido = int.TryParse(Console.ReadLine(), out num);

                if (!valido)
                {
                    Console.WriteLine("Número no valido");
                }

            } while (!valido);
            return num;

        }
    }
}
