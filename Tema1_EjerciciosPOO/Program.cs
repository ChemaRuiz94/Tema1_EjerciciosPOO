using System;




namespace Tema1_EjerciciosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int op = 0;
            bool salir = false;
            Utils u = new Utils();

            Console.WriteLine("EJERCICIOS TEMA 1 - CHEMA RUIZ");
            do
            {
                u.pintarMenu();

                op = u.pedirNum("Escoge una opcion: ");
                Console.WriteLine("______________________________");
                

                if (op >= 0 && op <= 4)
                {
                    switch (op)
                    {
                        case 1:
                            Console.WriteLine("Opcion 1");
                            ManejoFechas.MainFechas menu1 = new ManejoFechas.MainFechas();
                            menu1.pintarMenu();
                            menu1.menu();
                            break;
                        case 2:
                            Console.WriteLine("Opcion 2");
                            EjercicioLibros.MenuLibros menu2 = new EjercicioLibros.MenuLibros();
                            menu2.menu();
                            break;
                        case 3:
                            Console.WriteLine("Opcion 3");
                            AlquilerPuerto.MainPuerto menu3 = new AlquilerPuerto.MainPuerto();
                            menu3.menu();
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

        
    }
}
