using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1_EjerciciosPOO.AlquilerPuerto
{
    class Deportivo : Barco
    {
        private int cv;
        public int Cv
        {
            get { return cv; }
            set { cv = pedirCV(); }
        }


        public int pedirCV()
        {
            int cv;
            do
            {
                Console.WriteLine("Introduce la cantidad de caballos que tiene el deportivo");
                cv = int.Parse(Console.ReadLine());
            } while (cv < 0);
            return cv;
        }



        public Deportivo(string matricula, double eslora, int anioFabrica, int cv) : base(matricula, eslora, anioFabrica)
        {
            this.Cv = cv;

        }
    }
}
