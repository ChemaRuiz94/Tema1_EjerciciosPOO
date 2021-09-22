using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1_EjerciciosPOO.AlquilerPuerto
{
    class Velero : Barco
    {
        private int mastiles;

        public int Mastiles
        {
            get { return mastiles; }
            set { mastiles = value; }
        }


        public Velero(string matricula, double eslora, int anioFabrica, int mastiles) : base(matricula, eslora, anioFabrica)
        {
            this.Mastiles = mastiles;

        }
    }
}
