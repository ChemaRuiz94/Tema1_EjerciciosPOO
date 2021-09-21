using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1_EjerciciosPOO.AlquilerPuerto
{
    class Alquiler
    {

        private string nombreAlqui;

        public string NombreAlqui
        {
            get { return nombreAlqui; }
            set { nombreAlqui = value; }
        }

        private string dniAlqui;

        public string DniAlqui
        {
            get { return dniAlqui; }
            set { dniAlqui = value; }
        }

        private DateTime fechaInicio;

        public DateTime FechaInicio
        {
            get { return fechaInicio; }
            set { fechaInicio = value; }
        }

        private DateTime fechaFin;

        public DateTime FechaFin
        {
            get { return fechaFin; }
            set { fechaFin = value; }
        }

        private int posicionAmarre;

        public int PosicionAmarre
        {
            get { return posicionAmarre; }
            set { posicionAmarre = value; }
        }

        private string matriculaAlqui;

        public string MatriculaAlqui
        {
            get { return matriculaAlqui; }
            set { matriculaAlqui = value; }
        }

        public Alquiler(string nombre, string dni, DateTime fechaInicio, DateTime fechaFin, int posi, string matricula)
        {
            this.nombreAlqui = nombre;
            this.dniAlqui = dni;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
            this.posicionAmarre = posi;
            this.matriculaAlqui = matricula;

        }
    }
}
