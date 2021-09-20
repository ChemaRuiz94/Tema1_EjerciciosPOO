using System;
using System.Collections.Generic;
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
    }


}
