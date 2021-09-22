using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1_EjerciciosPOO.EjercicioLibros
{
    class UtilsMenuLibros
    {

        public UtilsMenuLibros() { }

        /*
        * Metodo para crear un Libro pidiendo todos los datos al usuario
        */
        public Libro crearLibro()
        {
            Console.WriteLine("Introduce el titulo del libro");
            string titulo = Console.ReadLine();

            Console.WriteLine("Introduce el autor del libro");
            string autor = Console.ReadLine();

            Console.WriteLine("Introduce el estilo del libro");
            string estilo = Console.ReadLine();

            Console.WriteLine("Introduce la editorial");
            string editorial = Console.ReadLine();

            Libro libro = new Libro(titulo, autor, estilo, editorial);
            return libro;
        }

        /*
         * Metodo para modificar un libro
         */
        public ArrayList modificarLibro(ArrayList listaLibros)
        {
            int posi = buscarPorTitulo(listaLibros);

            if (posi != -1) //si es -1 es porque no existe el libro
            {
                Libro newLibro = crearLibro();
                listaLibros[posi] = newLibro;

            }
            else
            {
                Console.WriteLine("El libro no existe");
            }
            return listaLibros;

        }

        /*
         * Metodo para eliminar un libro
         */
        public ArrayList eliminarLibro(ArrayList listaLibros)
        {
            int posi = buscarPorTitulo(listaLibros);

            if (posi != -1) //si es -1 es porque no existe el libro
            {
                listaLibros.RemoveAt(posi);

            }
            else
            {
                Console.WriteLine("El libro no existe");
            }
            return listaLibros;

        }

        /*
         * Para buscar un libro en la lista de libros
         * pidiendo al usuario el titulo del libro
         * SI EL LIBRO EXISTE DEVUELVE LA POSICION EN LA LISTA
         * SI EL LIBRO NO EXISTE DEVUELVE -1
         */
        public int buscarPorTitulo(ArrayList listaLibros)
        {
            Console.WriteLine("Introduce el titulo del libro");
            string titulo = Console.ReadLine();

            foreach (Libro libro in listaLibros)
            {
                if (libro.Titulo.Equals(titulo))
                    return listaLibros.IndexOf(libro); //devuelve la posi
            }
            return -1; //devuelve -1 si no existe
        }

        /**
         * Metodo para mostrar por pantalla la lista de libros
         */
        public void mostrarLista(ArrayList lista)
        {
            foreach (Libro item in lista)
            {
                item.pintarLibro();
            }
        }

        
    }
}
