using System;




namespace Tema1_EjerciciosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EJERCICIOS TEMA 1 - CHEMA RUIZ");
            int op = 0;
            bool salir = false;
            do
            {
                Console.WriteLine("______________________________");
                Console.WriteLine("1 -> Manejar Fechas");
                Console.WriteLine("2 -> Clase Libros");
                Console.WriteLine("3 -> Alquiler Puerto");
                Console.WriteLine("4 -> Salir");
                Console.WriteLine("______________________________");

                Console.WriteLine("Escoge una opcion: ");
                Console.WriteLine("______________________________");
                op = PedirOpcionUsuario();

                if (op >= 0 && op <= 4)
                {
                    switch (op)
                    {
                        case 1:
                            Console.WriteLine("Opcion 1");
                            ManejoFechas.MainFechas menu = new ManejoFechas.MainFechas();
                            menu.pintarMenu();
                            menu.menu();
                            break;
                        case 2:
                            Console.WriteLine("Opcion 2");
                            break;
                        case 3:
                            Console.WriteLine("Opcion 3");
                            break;
                        case 4:
                            Console.WriteLine("Hasta pronto!");
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("Opcion Incorrecta");
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("Introduce una opcion correcta");
                }
            } while (!salir);

        }

        public static int PedirOpcionUsuario()
        {
            return int.Parse(Console.ReadLine());
        }
    }
}
