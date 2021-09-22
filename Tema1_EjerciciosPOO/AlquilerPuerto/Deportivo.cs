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
            set { cv = value; }
        }


        public Deportivo(string matricula, double eslora, int anioFabrica, int cv) : base(matricula, eslora, anioFabrica)
        {
            this.Cv = cv;

        }
    }
}
