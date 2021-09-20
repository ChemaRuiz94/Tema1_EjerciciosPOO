using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1_EjerciciosPOO.ManejoFechas
{
    class MainFechas
    {
        public MainFechas()
        {
        }

        public void pintarMenu()
        {
            Console.WriteLine("EJERCICIO MANEJAR FECHAS");
            Console.WriteLine("______________________________");
            Console.WriteLine("1 -> DIA DE LA SEMANA");
            Console.WriteLine("     (Introducir una fecha y decir a que dia de la semana corresponde)");
            Console.WriteLine("2 -> INCREMENTAR FECHA");
            Console.WriteLine("     (Introducir una fecha e incrementarla en un numero de dias dado por el usuario)");
            Console.WriteLine("3 -> DIFERENCIAR FECHAS");
            Console.WriteLine("     (Introduces  dos  fechas  e  indicas  el  tiempo  en  años,  meses  y  días pasados entre las dos fechas)");
            Console.WriteLine("4 -> COMPARAR FECHAS");
            Console.WriteLine("     (Compara dos fechas e indica si la primera es mayor, menor o igual que la segunda fecha)");
            Console.WriteLine("5 -> MOSTRAR FECHAS EN FORMATO LARGO");
            Console.WriteLine("     (Introduce una fecha en formato corto (“dd/mm/aa”)) y se devuelve en formato largo");
            Console.WriteLine("______________________________");
            Console.WriteLine("ESCOGE UNA OPCION DE ESTE EJERCICIO: ");
            Console.WriteLine("______________________________");

        }

        public void menu()
        {
            int op = PedirOpcionUsuario();
            switch (op)
            {
                case 1:
                    Console.WriteLine("Opcion 1");
                    diaDeLaSemana();
                    break;
                case 2:
                    Console.WriteLine("Opcion 2");
                    break;
                case 3:
                    Console.WriteLine("Opcion 4");
                    break;
                case 4:
                    Console.WriteLine("Opcion 3");
                    break;
                case 5:
                    Console.WriteLine("Opcion 5");
                    break;
                default:
                    Console.WriteLine("Opcion Incorrecta");
                    break;

            }
        }

        public static void diaDeLaSemana()
        {

            DateTime fecha = pedirFechaUsuario();

            Console.WriteLine("Esa fecha corresponde a " + fecha.DayOfWeek.ToString());

        }

        /**
         * Metodo para pedir  datos al usuario 
         * y devolver la opcion del menu
         */
        public static int PedirOpcionUsuario()
        {
            return int.Parse(Console.ReadLine());
        }

        /**
         * Metodo para pedir  fecha al usuario 
         * y devolver la una fecha con formato
         */
        public static DateTime pedirFechaUsuario()
        {
            int anio;
            int mes;
            int dia;
            DateTime fecha = new DateTime();

            try
            {
                do
                {
                    Console.WriteLine("Introduce el año");
                    anio = int.Parse(Console.ReadLine());
                } while (anio < 1 || anio > 9999);

                do
                {
                    Console.WriteLine("Introduce el mes");
                    mes = int.Parse(Console.ReadLine());
                } while (mes < 1 || mes > 12);

                do
                {
                    Console.WriteLine("Introduce el dia");
                    dia = int.Parse(Console.ReadLine());
                } while (dia < 1 || dia > 31);

                fecha = new DateTime(anio, mes, dia);
            }
            catch (Exception)
            {
                Console.WriteLine("Fecha introducida erronea");
                throw;
            }
            return fecha;
        }
    }
}
