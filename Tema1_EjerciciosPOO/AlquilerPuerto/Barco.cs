using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1_EjerciciosPOO.AlquilerPuerto
{
    class Barco
    {
        private string matricula;
        private double eslora;
        private int anioFabrica;

        public string Matricula
        {
            get { return matricula; }
            set { matricula = pedirMatricula(); }
        }

        

        public double Eslora
        {
            get { return eslora; }
            set { eslora = pedirEslora(); }
        }

        

        public int AnioFabrica
        {
            get { return anioFabrica; }
            set { anioFabrica = pedirAnioFabrica(); }
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
            } while (anio < 0 || anio > 99);
            return anio;
        }

        public Barco(string matricula, double eslora, int anioFabrica)
        {
            this.matricula = matricula;
            this.eslora = eslora;
            this.anioFabrica = anioFabrica;

        }
    }
}
