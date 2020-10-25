using System;

namespace inventario_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion =0;
            string razon = "";

            Inventario inventario = new Inventario();

            while (true)
            {
                Console.Clear();

                Console.WriteLine("Sistema de Inventario");
                Console.WriteLine("***********************");
                Console.WriteLine();
                Console.WriteLine ("1 - Productos");
                Console.WriteLine ("2 - Ingreso de Inventario");
                Console.WriteLine ("3 - Salida de Inventario");
                Console.WriteLine ("4 - Ajuste Positivo de Inventario");
                Console.WriteLine ("5 - Ajuste Negativo de Inventario");
                Console.WriteLine ("0 - Salir");
                Console.WriteLine("");
                string linea =Console.ReadLine();
                opcion = int.Parse(linea);

                switch (opcion)
                {
                    case 1:                    
                        inventario.listarProductos();
                        break;
                    case 2:    
                        inventario.ingresoDeInventario();
                        break; 
                    case 3:
                        inventario.salidaDeInventario();
                        break;
                    case 4:
                        inventario.ajustePositivoDeInventario();
                        if (opcion == 4)
                        {
                            Console.Write("Especifique la razon del ajuste: ");
                            razon = Console.ReadLine();
                        }
                            if (string.IsNullOrEmpty(razon))
                                {
                                    Console.Write("Aviso!:Campo vacio. Debe especificar una razon para el ajuste: "); 
                                    Console.ReadLine(); 
                                        
                                }  
                        break;
                    case 5:
                        inventario.ajusteNegativoDeInventario();
                        if (opcion == 5)
                        {
                           Console.Write("Especifique la razon del ajuste: ");
                           razon = Console.ReadLine();                             
                        }                        
                             if (string.IsNullOrEmpty(razon))
                            {
                                Console.Write("Aviso!:Campo vacio. Debe especificar una razon para el ajuste: "); 
                                Console.ReadLine(); 
                                       
                            }                       
                    break;
                   
                    default:
                     break;
                }        

                if (opcion == 0)
                {
                    break;
                }    
            }
        }
    }
}
