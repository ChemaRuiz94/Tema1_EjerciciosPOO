﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1_EjerciciosPOO.AlquilerPuerto
{
    class UtilsPuerto
    {
        public UtilsPuerto() { }

        public Barco crearBarco()
        {


            Barco barco = new Barco(pedirMatricula(), pedirEslora(), pedirAnioFabrica());
            return barco;
        }

        public Velero crearVelero()
        {

            Velero velero = new Velero(pedirMatricula(), pedirEslora(), pedirAnioFabrica(), pedirMastiles());
            return velero;
        }

        public Deportivo crearDeportivo()
        {

            Deportivo deportivo = new Deportivo(pedirMatricula(), pedirEslora(), pedirAnioFabrica(), pedirCV());
            return deportivo;
        }

        public Yate crearYate()
        {

            Yate yate = new Yate(pedirMatricula(), pedirEslora(), pedirAnioFabrica(), pedirCV(), pedirMastiles());
            return yate;
        }

        public Persona crearPersona()
        {
            Persona persona = new Persona(pedirNombre(), pedirDni());
            return persona;

        }


        public Alquiler crearAlquiler(Barco barco, int posiBarco, Persona cliente)
        {
            Alquiler alquiler = new Alquiler(cliente.Nombre, cliente.Dni, pedirFechaInicio(), pedirFechaFin(), posiBarco, barco.Matricula);
            return alquiler;
        }
        public String pedirNombre()
        {
            String nombre;
            do
            {
                Console.WriteLine("Introduce el nombre del cliente");
                nombre = Console.ReadLine();
            } while (nombre.Equals("") || nombre.Equals(" "));
            return nombre;
        }

        public String pedirDni()
        {
            String dni;
            do
            {
                Console.WriteLine("Introduce el DNI del cliente (LA LETRA EN MAYUSCULA)");
                dni = Console.ReadLine();


            } while (!CheckDNI(dni));
            return dni;
        }

        public String pedirMatricula()
        {
            String matricula;
            do
            {
                Console.WriteLine("Introduce la matricula del barco");
                matricula = Console.ReadLine();
            } while (matricula.Equals("") || matricula.Equals(" "));
            return matricula;
        }

        /**
         * Eslora en double
         * para almacenar los metros
         */
        public double pedirEslora()
        {
            double eslora;
            do
            {
                Console.WriteLine("Introduce los metros de eslora del barco");
                eslora = double.Parse(Console.ReadLine());
            } while (eslora < 0);
            return eslora;
        }

        public int pedirAnioFabrica()
        {
            int anio;
            do
            {
                Console.WriteLine("Introduce el año de fabricacion del barco");
                anio = int.Parse(Console.ReadLine());
            } while (anio < 0 || anio > 9999);
            return anio;
        }

        public int pedirMastiles()
        {
            int mastiles;
            do
            {
                Console.WriteLine("Introduce la cantidad de mastiles del barco");
                mastiles = int.Parse(Console.ReadLine());
            } while (mastiles < 0);
            return mastiles;
        }

        public int pedirCV()
        {
            int cv;
            do
            {
                Console.WriteLine("Introduce la cantidad de caballos que tiene el barco");
                cv = int.Parse(Console.ReadLine());
            } while (cv < 0);
            return cv;
        }

        public int pedirPosi()
        {
            int posi;
            do
            {
                Console.WriteLine("Introduce la posicion del barco que quieres seleccionar");
                posi = int.Parse(Console.ReadLine());
                posi--;
            } while (posi < 0);
            return posi;
        }

        public static DateTime pedirFechaInicio()
        {
            DateTime fecha = new DateTime();
            bool correcto;

            do
            {
                Console.WriteLine("Introduce la fecha inicial del amarre");
                correcto = DateTime.TryParse(Console.ReadLine(), out fecha);

                if (!correcto)
                {
                    Console.WriteLine("Fecha no valida");
                }
            } while (!correcto);

            return fecha;
        }

        public static DateTime pedirFechaFin()
        {
            DateTime fecha = new DateTime();
            bool correcto;

            do
            {
                Console.WriteLine("Introduce una fecha hasta la que permanecerá el amarre");
                correcto = DateTime.TryParse(Console.ReadLine(), out fecha);

                if (!correcto)
                {
                    Console.WriteLine("Fecha no valida");
                }
            } while (!correcto);

            return fecha;
        }


        public bool comprobarPosi(int posi, List<Barco> lista)
        {
            bool correcto = false;
            for (int i = 0; i < lista.Count; i++)
            {
                if (posi == i)
                {
                    correcto = true;
                }
            }
            return correcto;
        }


        public bool CheckDNI(string dni)
        {
            //Comprobamos si el DNI tiene 9 digitos
            if (dni.Length != 9)
            {
                //No es un DNI Valido
                return false;
            }

            //Extraemos los números y la letra
            string dniNumbers = dni.Substring(0, dni.Length - 1);
            string dniLeter = dni.Substring(dni.Length - 1, 1);
            //Intentamos convertir los números del DNI a integer
            var numbersValid = int.TryParse(dniNumbers, out int dniInteger);
            if (!numbersValid)
            {
                //No se pudo convertir los números a formato númerico
                return false;
            }
            if (CalculateDNILeter(dniInteger) != dniLeter)
            {
                //La letra del DNI es incorrecta
                return false;
            }
            //DNI Valido :)
            return true;
        }


        public string CalculateDNILeter(int dniNumbers)
        {
            //Cargamos los digitos de control
            string[] control = { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };
            var mod = dniNumbers % 23;
            return control[mod];
        }
    }
}
