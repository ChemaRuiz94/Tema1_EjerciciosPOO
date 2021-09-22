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
            set { mastiles = pedirMastiles(); }
        }

        public int pedirMastiles()
        {
            int mastiles;
            do
            {
                Console.WriteLine("Introduce la cantidad de mastiles del velero");
                mastiles = int.Parse(Console.ReadLine());
            } while (mastiles < 0);
            return mastiles;
        }

        public Velero(string matricula, double eslora, int anioFabrica, int mastiles) : base(matricula, eslora, anioFabrica)
        {
            this.Mastiles = mastiles;

        }
    }
}
