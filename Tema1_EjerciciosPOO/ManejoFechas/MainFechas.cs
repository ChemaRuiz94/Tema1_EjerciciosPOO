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
            Console.WriteLine("(Introducir una fecha y decir a que dia de la semana corresponde)");
            Console.WriteLine("2 -> INCREMENTAR FECHA");
            Console.WriteLine("(Introducir una fecha e incrementarla en un numero de dias dado por el usuario)");
            Console.WriteLine("3 -> DIFERENCIAR FECHAS");
            Console.WriteLine("(Introduces  dos  fechas  e  indicas  el  tiempo  en  años,  meses  y  días pasados entre las dos fechas)");
            Console.WriteLine("4 -> COMPARAR FECHAS");
            Console.WriteLine("(Compara dos fechas e indica si la primera es mayor, menor o igual que la segunda fecha)");
            Console.WriteLine("5 -> MOSTRAR FECHAS EN FORMATO LARGO");
            Console.WriteLine("(Introduce una fecha en formato corto (“dd/mm/aa”)) y se devuelve en formato largo");
            Console.WriteLine("______________________________");

        }
    }
}
