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

        }

        public void menu()
        {
            UtilsFechas u = new UtilsFechas();
            Utils ut = new Utils();

            int op = ut.pedirNum("ESCOGE UNA OPCION DE ESTE EJERCICIO: ");
            Console.WriteLine("________________________________________");

            switch (op)
            {
                case 1:
                    Console.WriteLine("Opcion 1");
                    u.diaDeLaSemana();
                    break;
                case 2:
                    Console.WriteLine("Opcion 2");
                    u.incrementarFecha();
                    break;
                case 3:
                    Console.WriteLine("Opcion 3");
                    u.diferenciarFechas();
                    break;
                case 4:
                    Console.WriteLine("Opcion 4");
                    u.ResultadoCompararFechas(u.compararFechas());
                    break;
                case 5:
                    Console.WriteLine("Opcion 5");
                    DateTime fecha = u.pedirFecha();
                    Console.WriteLine("FECHA EN FORMATO LARGO " + fecha);
                    break;
                default:
                    Console.WriteLine("Opcion Incorrecta");
                    break;

            }
        }

       
       
    }
}
