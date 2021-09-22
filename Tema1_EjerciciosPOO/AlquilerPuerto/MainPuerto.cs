using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1_EjerciciosPOO.AlquilerPuerto
{
    class MainPuerto
    {
        public MainPuerto() { }

        public void pintarMenu()
        {
            Console.WriteLine("______________________________");
            Console.WriteLine("EJERCICIO ALQUILER PUERTO");
            Console.WriteLine("______________________________");
            Console.WriteLine("1 -> REGISTRAR UN NUEVO BARCO EN EL PUERTO");
            Console.WriteLine("     (Nuevo barco asociado a un cliente y añadirlo a nuestro puerto)");
            Console.WriteLine("2 -> VER LISTADO DE AMARRES");
            Console.WriteLine("     (Mostrar nuestra lista de los barcos amarrados)");
            Console.WriteLine("3 -> CALCULAR EL ALQUILER DE ALGUN BARCO");
            Console.WriteLine("     (Seleccione un barco de la lista y calcule el alquiler del amarre)");
            Console.WriteLine("4 -> SALIR");
            Console.WriteLine("______________________________");
            Console.WriteLine("ESCOGE UNA OPCION DE ESTE EJERCICIO: ");
            Console.WriteLine("______________________________");

        }


        public void pintarSeleccionarTipoBarco()
        {
            Console.WriteLine("______________________________");
            Console.WriteLine("¿QUE TIPO DE BARCO QUIERES REGISTRAR. ESCOGE UNA OPCION: ");
            Console.WriteLine("______________________________");
            Console.WriteLine("1 -> EMBARCACION NORMAL");
            Console.WriteLine("2 -> EMBARCACION DEPORTIVA A MOTRO");
            Console.WriteLine("3 -> EMBARCACION DE LUJO");
            Console.WriteLine("4 -> VELERO");
        }

        public void menu()
        {
            Puerto puerto = new Puerto();
            UtilsPuerto u = new UtilsPuerto();
            int op = 0;

            do
            {
                pintarMenu();
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        registrarTipoBarco(puerto);
                        break;
                    case 2:
                        puerto.mostrarListaAlquiler();
                        break;
                    case 3:
                        mostrarAlquilerBarco(puerto, u);
                        break;
                    case 4:
                        Console.WriteLine("HASTA PRONTO");
                        break;
                    default:
                        Console.WriteLine("Escoge una opcion correcta");
                        break;
                }

            } while (op != 4);
        }

        public void registrarTipoBarco(Puerto puerto)
        {
            UtilsPuerto u = new UtilsPuerto();
            int op, posi;
            Persona cliente;
            Barco barco;
            Alquiler alquiler;

            do
            {
                pintarSeleccionarTipoBarco();
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        barco = u.crearBarco();
                        Console.WriteLine("¿A QUE CLIENTE SE ASOCIA ESTA EMBARCACION? ");
                        cliente = u.crearPersona();

                        puerto.addBarco(barco);
                        puerto.addCliente(cliente);
                        posi = puerto.ListaBarcos.IndexOf(barco);

                        alquiler = u.crearAlquiler(barco, posi, cliente);
                        puerto.addAlquiler(alquiler);

                        break;
                    case 2:
                        Deportivo deportivo = u.crearDeportivo();
                        Console.WriteLine("¿A QUE CLIENTE SE ASOCIA ESTA EMBARCACION? ");
                        cliente = u.crearPersona();

                        puerto.addBarco(deportivo);
                        puerto.addCliente(cliente);
                        posi = puerto.ListaBarcos.IndexOf(deportivo);

                        alquiler = u.crearAlquiler(deportivo, posi, cliente);
                        puerto.addAlquiler(alquiler);

                        break;
                    case 3:
                        Yate yate = u.crearYate();
                        Console.WriteLine("¿A QUE CLIENTE SE ASOCIA ESTA EMBARCACION? ");
                        cliente = u.crearPersona();

                        puerto.addBarco(yate);
                        puerto.addCliente(cliente);
                        posi = puerto.ListaBarcos.IndexOf(yate);

                        alquiler = u.crearAlquiler(yate, posi, cliente);
                        puerto.addAlquiler(alquiler);

                        break;
                    case 4:
                        Velero velero = u.crearVelero();
                        Console.WriteLine("¿A QUE CLIENTE SE ASOCIA ESTA EMBARCACION? ");
                        cliente = u.crearPersona();

                        puerto.addBarco(velero);
                        puerto.addCliente(cliente);
                        posi = puerto.ListaBarcos.IndexOf(velero);

                        alquiler = u.crearAlquiler(velero, posi, cliente);
                        puerto.addAlquiler(alquiler);

                        break;
                    default:
                        Console.WriteLine("DEFAULT");
                        break;
                }

            } while (op < 1 || op > 4);
            Console.WriteLine("BARCO REGISTRADO CON EXITO Y ANCLADO EN LA POSICION " + puerto.ListaBarcos.Count() );
        }

        public void mostrarAlquilerBarco(Puerto puerto, UtilsPuerto u)
        {
            int posi = u.pedirPosi();
            if (u.comprobarPosi(posi, puerto.ListaBarcos))
            {
                double resultado = puerto.calcularAlquilerPuerto(posi);
                Alquiler alquiler = puerto.ListaAlquileres[posi];

                puerto.pintarAlquiler(alquiler);
                Console.WriteLine("El ALQUILER DEL BARCO ES " + resultado + " EUROS");
            }
            else
            {
                Console.WriteLine("El alquiler del barco");
            }
        }
    }



}
