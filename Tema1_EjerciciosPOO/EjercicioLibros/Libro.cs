using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1_EjerciciosPOO.EjercicioLibros
{
    class Libro
    {


        private string titulo;

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        private string autor;

        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }

        private string estilo;

        public string Estilo
        {
            get { return estilo; }
            set { estilo = value; }
        }

        private string editorial;

        public string Editorial
        {
            get { return editorial; }
            set { editorial = value; }
        }


        public Libro(string titulo, string autor, string estilo, string editorial)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.estilo = estilo;
            this.editorial = editorial;

        }

       
    }
}
