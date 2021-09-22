using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1_EjerciciosPOO.AlquilerPuerto
{
    
    class Puerto
    {
        public Puerto() 
        {
        
        }

        private ArrayList listaClientes = new ArrayList();

        public ArrayList ListaClientes
        {
            get { return listaClientes; }
            set { listaClientes = value; }
        }

        private List<Barco> listaBarcos = new List<Barco>();

        public List<Barco> ListaBarcos
        {
            get { return listaBarcos; }
            set { listaBarcos = value; }

        }


        private List<Alquiler> listaAlquileres = new List<Alquiler>();

        public List<Alquiler> ListaAlquileres
        {
            get { return listaAlquileres; }
            set { listaAlquileres = value; }
        }

        public void addCliente(Persona cliente) 
        {
            this.listaClientes.Add(cliente);
        }

        public void addBarco(Barco barco)
        {
            this.listaBarcos.Add(barco);
        }

        public void addAlquiler(Alquiler alquiler) 
        {
            this.listaAlquileres.Add(alquiler);
        }

        public void mostrarListaAlquiler()
        {
            foreach (Alquiler item in listaAlquileres)
            {
                pintarAlquiler(item);
            }
        }


        public void pintarAlquiler(Alquiler alquiler)
        {
            Console.WriteLine("NOMBRE DEL PROPIETARIO: " + alquiler.NombreAlqui + ", DNI DEL PROPIETARIO: " + alquiler.DniAlqui + ", " +
                "\n FECHA DE ENTRADA: " + alquiler.FechaInicio + ", FECHA DE SALIDA: " +alquiler.FechaFin +", " +
                "\n POSICION: " + (alquiler.PosicionAmarre + 1) + ", MATRICULA DEL BARCO: " + alquiler.MatriculaAlqui );
            Console.WriteLine("_________________________________________________________");
        }

        public double calcularAlquilerPuerto(int posi) 
        {
            double resultado;

            Alquiler alquiler = listaAlquileres[posi];
            Barco barco = listaBarcos[posi];

            //instanceOf

            resultado = alquiler.calcularAlquilerEspecial(barco);
            return resultado;
        }
    }

}
