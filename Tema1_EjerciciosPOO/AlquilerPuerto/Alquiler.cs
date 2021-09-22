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
        private string dniAlqui;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private int posicionAmarre;
        private string matriculaAlqui;

        public string NombreAlqui
        {
            get { return nombreAlqui; }
            set { nombreAlqui = value; }
        }



        public string DniAlqui
        {
            get { return dniAlqui; }
            set { dniAlqui = value; }
        }



        public DateTime FechaInicio
        {
            get { return fechaInicio; }
            set { fechaInicio = value; }
        }



        public DateTime FechaFin
        {
            get { return fechaFin; }
            set { fechaFin = value; }
        }



        public int PosicionAmarre
        {
            get { return posicionAmarre; }
            set { posicionAmarre = value; }
        }



        public string MatriculaAlqui
        {
            get { return matriculaAlqui; }
            set { matriculaAlqui = value; }
        }

        public double calcularAlquilerNormal(Barco barco)
        {
            double tamanio, aux;

            tamanio = (barco.Eslora * 10);

            var diferencia = fechaFin - fechaInicio;
            int dias = (int)(diferencia.TotalDays);

            aux = (dias * tamanio);

            return (aux * 12);
        }

        public double calcularAlquilerEspecial(Barco barco)
        {
            double resultado = calcularAlquilerNormal(barco);

            var b = barco.GetType();

            if (barco is Velero v)
            {
                resultado = resultado + v.Mastiles;
                Console.WriteLine("Es un velero");
            }

            if (barco is Deportivo d)
            {
                resultado = resultado + d.Cv;
                Console.WriteLine("Es un Deportivo");
            }

            if (barco is Yate y)
            {
                resultado = resultado + y.Cv + y.Mastiles;
                Console.WriteLine("Es un Yate");
            }

            return resultado;
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
