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
            set { matricula = value; }
        }

        

        public double Eslora
        {
            get { return eslora; }
            set { eslora = value; }
        }

        

        public int AnioFabrica
        {
            get { return anioFabrica; }
            set { anioFabrica = value; }
        }


        public Barco() 
        { 

        }
        public Barco(string matricula, double eslora, int anioFabrica)
        {
            this.matricula = matricula;
            this.eslora = eslora;
            this.anioFabrica = anioFabrica;

        }
    }
}
