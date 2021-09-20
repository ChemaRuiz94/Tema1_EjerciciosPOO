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
                    incrementarFecha();
                    break;
                case 3:
                    Console.WriteLine("Opcion 3");
                    diferenciarFechas();
                    break;
                case 4:
                    Console.WriteLine("Opcion 4");
                    ResultadoCompararFechas(compararFechas());
                    break;
                case 5:
                    Console.WriteLine("Opcion 5");
                    break;
                default:
                    Console.WriteLine("Opcion Incorrecta");
                    break;

            }
        }

        /**
         * Metodo para la opcion 1 del ejercicio
         * Dada una fecha por el usuario, devolver en español el dia de la semana
         */
        public static void diaDeLaSemana()
        {
            string dia = "";
            DateTime fecha = pedirFechaUsuario();

            switch (fecha.DayOfWeek.ToString())
            {
                case "Monday":
                    dia = "Lunes";
                    break;
                case "Tuesday":
                    dia = "Martes";
                    break;
                case "Wednesday":
                    dia = "Miercoles";
                    break;
                case "Thursday":
                    dia = "Jueves";
                    break;
                case "Friday":
                    dia = "Viernes";
                    break;
                case "Saturday":
                    dia = "Sabado";
                    break;
                case "Sunday":
                    dia = "Domingo";
                    break;
                default:
                    dia = "ERROR";
                    break;

            }

            Console.WriteLine("Esa fecha corresponde a " + dia);

        }

        /**
         * Metodo para la opcion 2 del ejercicio
         * Dada una fecha por el usuario, incrementarla en 
         * un numero de dias dado por el usuario y devolver esa fecha
         */
        public static void incrementarFecha()
        {
            DateTime fecha = pedirFechaUsuario();
            Console.WriteLine("En cuantos dias quieres incrementar esta fecha");
            double incremento = double.Parse(Console.ReadLine());

            DateTime nuevaFecha = fecha.AddDays(incremento);
            Console.WriteLine("Esa fecha corresponde a " + nuevaFecha.ToString());
        }


        /**
         * Metodo para la opcion 3 del ejercicio
         * Devolver en dias meses y años la diferencia entre dos fechas
         */
        public static void diferenciarFechas()
        {
            /**
            DateTime fecha1 = pedirFechaUsuario();
            Console.WriteLine("Ahora la fecha que quieres comparar");
            DateTime fecha2 = pedirFechaUsuario();

            System.TimeSpan fecha3 = fecha1.Subtract(fecha2);
            Console.WriteLine("Hay " + fecha3.ToString() + " de diferencia");
            */
            Console.WriteLine("SIN ACABAR - FALLO: DEVUELVE DE FORMATO EN HORAS");

        }

        /**
         * Metodo para la opcion 4 del ejercicio
         * De dos fechas dadas, decir si una es anterior, igual o posterior a la otra
         * Devuelve un entero con el resultado 
         */
            public static int compararFechas()
        {
            int resul;
            DateTime fecha1 = pedirFechaUsuario();
            Console.WriteLine("Ahora la fecha que quieres comparar");
            DateTime fecha2 = pedirFechaUsuario();

            

            return resul = DateTime.Compare(fecha1, fecha2);
        }

        /**
         * Metodo para la opcion 4 del ejercicio
         * De dos fechas dadas, decir si una es anterior, igual o posterior a la otra
         * Recibe un entero y pinta el resultado
         */
        public static void ResultadoCompararFechas(int resul)
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
                    Console.WriteLine("ERROR");
                    break;
            }
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

        public static DateTime pedirFechaUsuarioFormatoCorto() 
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
                } while (anio < 01 || anio > 99);

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
