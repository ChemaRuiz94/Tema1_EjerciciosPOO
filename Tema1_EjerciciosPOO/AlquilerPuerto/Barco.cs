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

        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        private int eslora;

        public int Eslora
        {
            get { return eslora; }
            set { eslora = value; }
        }

        private int anioFabrica;

        public int AnioFabrica
        {
            get { return anioFabrica; }
            set { anioFabrica = value; }
        }

        private int mastiles;

        public int Mastiles
        {
            get { return mastiles; }
            set { mastiles = value; }
        }

        private int cv;

        public int Cv
        {
            get { return cv; }
            set { cv = value; }
        }

        private int camarotes;

        public int Camarotes
        {
            get { return camarotes; }
            set { camarotes = value; }
        }

        private string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public Barco(string matricula, int eslora, int anioFabrica)
        {
            this.matricula = matricula;
            this.eslora = eslora;
            this.anioFabrica = anioFabrica;

        }
    }
}
