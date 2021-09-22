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
            UtilsMenuLibros u = new UtilsMenuLibros();
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
                            Libro libro = u.crearLibro();
                            listaLibros.Add(libro);

                            break;
                        case 2:
                            Console.WriteLine("Opcion 2");
                            u.mostrarLista(listaLibros);

                            break;
                        case 3:
                            Console.WriteLine("Opcion 3");
                            u.modificarLibro(listaLibros);
                            break;
                        case 4:
                            Console.WriteLine("Opcion 4");
                            u.eliminarLibro(listaLibros);
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

    }




}
