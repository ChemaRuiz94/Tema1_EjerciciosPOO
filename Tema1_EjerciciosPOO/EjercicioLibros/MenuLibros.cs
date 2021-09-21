using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1_EjerciciosPOO.EjercicioLibros
{
    class MenuLibros
    {
        public MenuLibros()
        {

        }

        /*
         * Metodo para pintar las opciones del menu
         */
        public void pintarMenu()
        {
            Console.WriteLine("______________________________");
            Console.WriteLine("EJERCICIO CLASE LIBROS");
            Console.WriteLine("______________________________");
            Console.WriteLine("1 -> INSERTAR UN LIBRO");
            Console.WriteLine("     (Crear un objeto libro y añadirlo a nuestra lista)");
            Console.WriteLine("2 -> VER LISTADO LIBROS");
            Console.WriteLine("     (Mostrar nuestra lista de libros)");
            Console.WriteLine("3 -> MODIFICAR ALGUN LIBRO DE LA LISTA");
            Console.WriteLine("     (Seleccione un libro de la lista y modifique alguno de sus campos)");
            Console.WriteLine("4 -> ELIMINAR ALGUN LIBRO DE LA LISTA");
            Console.WriteLine("     (Seleccione un libro de la lista para eliminarlo)");
            Console.WriteLine("5 -> SALIR");
            Console.WriteLine("______________________________");
            Console.WriteLine("ESCOGE UNA OPCION DE ESTE EJERCICIO: ");
            Console.WriteLine("______________________________");

        }

        /**
         * Metodo para el menu
         * 
         */
        public void menu()
        {
            int op;
            bool salir = false;
            ArrayList listaLibros = new ArrayList();
            do
            {
                pintarMenu();
                op = int.Parse(Console.ReadLine());

                if (op >= 0 && op <= 5)
                {
                    switch (op)
                    {
                        case 1:
                            Console.WriteLine("Opcion 1");
                            Libro libro = crearLibro();
                            listaLibros.Add(libro);

                            break;
                        case 2:
                            Console.WriteLine("Opcion 2");
                            mostrarLista(listaLibros);

                            break;
                        case 3:
                            Console.WriteLine("Opcion 3");
                            modificarLibro(listaLibros);
                            break;
                        case 4:
                            Console.WriteLine("Opcion 4");
                            eliminarLibro(listaLibros);
                            break;
                        case 5:
                            Console.WriteLine("Hasta pronto!");
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("Opcion Incorrecta");
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("Introduce una opcion correcta");
                }
            } while (!salir);
        }

        /*
         * Metodo para crear un Libro pidiendo todos los datos al usuario
         */
        public static Libro crearLibro()
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
        public static ArrayList modificarLibro(ArrayList listaLibros)
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
        public static ArrayList eliminarLibro(ArrayList listaLibros)
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
        public static int buscarPorTitulo(ArrayList listaLibros)
        {
            Console.WriteLine("Introduce el titulo del libro");
            string titulo = Console.ReadLine();

            int posi = -1; //si no existe el libro devuelve -1

            for (int i = 0; i < listaLibros.Count; i++)
            {
                if (listaLibros[i].Equals(titulo))
                {
                    posi = i; //si existe el libro, devuelve la posi
                }
            }
            return posi;
        }

        /**
         * Metodo para mostrar por pantalla la lista de libros
         */
        public static void mostrarLista(ArrayList lista)
        {
            foreach (Libro item in lista)
            {
                pintarLibro(item);
            }
        }

        /*
         * Metodo para mostrar por pantalla los datos de un libro
         */
        public static void pintarLibro(Libro libro)
        {
            Console.WriteLine("TITULO: " + libro.Titulo + ", AUTOR: " + libro.Autor + ", ESTILO: " + libro.Estilo + ", EDITORIAL: " + libro.Editorial);
        }


    }




}
