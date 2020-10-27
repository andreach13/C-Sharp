using System;

namespace _10_Ordenes
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion = "";
            DatosdePrueba datos = new DatosdePrueba();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Sistema de Ordenes");
                Console.WriteLine("******************");
                Console.WriteLine(" ");
                Console.WriteLine("1 - Lista de Productos");
                Console.WriteLine("2 - Crear Orden");
                Console.WriteLine("3 - Lista de clientes");
                Console.WriteLine("4 - Lista de Vendedores");
                Console.WriteLine("5 - Lista de Ordenes");
                Console.WriteLine("0 - Salir");
                Console.WriteLine(" ");

                Console.Write("Ingrese una opcion: ");
                opcion = Console.ReadLine();
                Console.WriteLine(" ");

                switch (opcion)
                {
                    case "1":
                        datos.ListarProductos();
                        break;
                    case "2":
                        datos.CrearOrden();
                        break;
                    case "3":
                        datos.ListarClientes();
                        break;
                    case "4":
                        datos.ListarVendedores();
                        break;
                    case "5":
                    datos.ListarOrdenes();
                    break;    
                     
                    default:
                    break;
                }

                if (opcion == "0")
                {
                    break;
                }
            }
        }
    }
}
