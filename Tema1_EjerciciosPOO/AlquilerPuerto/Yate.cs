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
            set { mastiles = pedirMastiles(); }
        }

        public int Cv
        {
            get { return cv; }
            set { cv = pedirCV(); }
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

        public Yate(string matricula, double eslora, int anioFabrica, int cv, int mastiles) : base(matricula, eslora, anioFabrica)
        {
            this.Cv = cv;
            this.Mastiles = mastiles;

        }

    }
}
