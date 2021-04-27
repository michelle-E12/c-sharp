using System;

namespace _9_Proyecto_SistemaDeDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ListasDeDatos datos = new ListasDeDatos();
            string opcion = "";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("   SISTEMA DE DELIVERY   ");
                Console.WriteLine("=========================");
                Console.WriteLine("");
                Console.WriteLine("1 - Menu");
                Console.WriteLine("2 - Crear Orden");
                Console.WriteLine("3 - Lista de Ordenes");
                Console.WriteLine("0 - Salir");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        datos.ListarProductos();
                        break;
                    case "2":
                        datos.CrearOrden();
                        break;                                            
                    case "3":
                        datos.ListarOrdenes();
                        break;                                          
                    default:
                        break;
                }

                if (opcion == "0") {
                    break;
                }
            }
        }
    }
}
