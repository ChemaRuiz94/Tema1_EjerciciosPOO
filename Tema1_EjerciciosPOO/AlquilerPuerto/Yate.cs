using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1_EjerciciosPOO.AlquilerPuerto
{
    class Yate : Barco
    {
        private int mastiles;
        private int cv;

        public int Mastiles
        {
            get { return mastiles; }
            set { mastiles = value; }
        }

        public int Cv
        {
            get { return cv; }
            set { cv = value; }
        }

        

        public Yate(string matricula, double eslora, int anioFabrica, int cv, int mastiles) : base(matricula, eslora, anioFabrica)
        {
            this.Cv = cv;
            this.Mastiles = mastiles;

        }

    }
}
