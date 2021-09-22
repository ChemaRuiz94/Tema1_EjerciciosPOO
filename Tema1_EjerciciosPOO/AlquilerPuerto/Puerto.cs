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

        private ArrayList listaBarcos = new ArrayList();

        public ArrayList ListaBarcos
        {
            get { return listaClientes; }
            set { listaClientes = value; }

        }


        private ArrayList listaAlquileres = new ArrayList();

        public ArrayList ListaAlquileres
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
    }

}
