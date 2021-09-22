using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1_EjerciciosPOO.ManejoFechas
{
    class UtilsFechas
    {
        public UtilsFechas()
        {

        }

        /**
        * Metodo para pedir fecha al usuario
        * 
        */
        public DateTime pedirFecha()
        {
            DateTime fecha = new DateTime();
            bool correcto;

            do
            {
                Console.WriteLine("Introduce una fecha");
                correcto = DateTime.TryParse(Console.ReadLine(), out fecha);

                if (!correcto)
                {
                    Console.WriteLine("Fecha no valida");
                }
            } while (!correcto);

            return fecha;
        }

        /**
        * Metodo para la opcion 1 del ejercicio
        * Dada una fecha por el usuario, devolver en español el dia de la semana
        */
        public void diaDeLaSemana()
        {
            DateTime fecha = pedirFecha();


            string dia = (fecha.ToString("dddd",
                        new CultureInfo("es-ES")));

            Console.WriteLine("Esa fecha corresponde a " + dia);

        }

        /**
         * Metodo para la opcion 2 del ejercicio
         * Dada una fecha por el usuario, incrementarla en 
         * un numero de dias dado por el usuario y devolver esa fecha
         */
        public void incrementarFecha()
        {
            DateTime fecha = pedirFecha();
            Console.WriteLine("En cuantos dias quieres incrementar esta fecha");
            int incremento = int.Parse(Console.ReadLine());

            DateTime nuevaFecha = fecha.AddDays(incremento);
            Console.WriteLine("Esa fecha corresponde a " + nuevaFecha.ToString());
        }


        /**
         * Metodo para la opcion 3 del ejercicio
         * Devolver en dias meses y años la diferencia entre dos fechas
         */
        public void diferenciarFechas()
        {

            DateTime fecha1 = pedirFecha();
            Console.WriteLine("Ahora la fecha que quieres comparar ");
            DateTime fecha2 = pedirFecha();

            int anio, mes, dia;

            if (fecha1.Year < fecha2.Year || fecha1.Month < fecha2.Month || fecha1.Day < fecha2.Day)
            {
                var diferencia = fecha2 - fecha1;
                anio = (int)(diferencia.TotalDays / 365.25);
                mes = (int)(((diferencia.TotalDays / 365.25) - anio) * 12);
                dia = (int)(fecha2.Day - fecha1.Day);
            }
            else
            {
                var diferencia = fecha1 - fecha2;
                anio = (int)(diferencia.TotalDays / 365.25);
                mes = (int)(((diferencia.TotalDays / 365.25) - anio) * 12);
                dia = (int)(fecha1.Day - fecha2.Day);
            }
            Console.WriteLine("Hay " + anio + " años " + mes + " meses y " + dia + " dias de diferencia entre las fechas");
        }

        /**
         * Metodo para la opcion 4 del ejercicio
         * De dos fechas dadas, decir si una es anterior, igual o posterior a la otra
         * Devuelve un entero con el resultado -1 , 0 o 1
         */
        public int compararFechas()
        {
            int resul;
            DateTime fecha1 = pedirFecha();
            Console.WriteLine("Ahora la fecha que quieres comparar");
            DateTime fecha2 = pedirFecha();

            return resul = DateTime.Compare(fecha1, fecha2);
        }

        /**
         * Metodo para la opcion 4 del ejercicio
         * De dos fechas dadas, decir si una es anterior, igual o posterior a la otra
         * Recibe un entero y pinta el resultado
         */
        public void ResultadoCompararFechas(int resul)
        {
            switch (resul)
            {
                case < 0:
                    Console.WriteLine("La primera fecha es anterior a la segunda");
                    break;
                case 0:
                    Console.WriteLine("Las dos fechas son iguales");
                    break;
                case > 0:
                    Console.WriteLine("La segunda fecha es anterior a la primera");
                    break;
                default:
                    Console.WriteLine("DEFAULT");
                    break;
            }
        }

    }
}
