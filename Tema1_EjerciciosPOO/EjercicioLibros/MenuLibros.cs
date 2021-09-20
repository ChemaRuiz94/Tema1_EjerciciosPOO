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
        public MenuLibros() { }

        public void pintarMenu()
        {
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

        public void menu()
        {
            int op;
            bool salir = false;
            ArrayList listaLibros = new ArrayList();
            do
            {
                pintarMenu();
                op = int.Parse(Console.ReadLine());

                if (op >= 0 && op <= 4)
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

                            break;
                        case 3:
                            Console.WriteLine("Opcion 3");
                            break;
                        case 4:
                            Console.WriteLine("Opcion 4");
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

      
    }


}
