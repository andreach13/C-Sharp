using System;

namespace _12_Tarea_Ej_Animales
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion = "";
            ReinoAnimal rn = new ReinoAnimal();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("************************************************************");
                Console.WriteLine("               Guia de Clasificacion Animal                  ");
                Console.WriteLine("************************************************************");
                Console.WriteLine(" ");
                Console.WriteLine("1 - Anfibios");
                Console.WriteLine("2 - Aves");
                Console.WriteLine("3 - Mamiferos");
                Console.WriteLine("4 - Peces");
                Console.WriteLine("5 - Reptiles");
                Console.WriteLine("0 - Salir");
                Console.WriteLine(" ");

                Console.Write("Ingrese una opcion: ");
                opcion = Console.ReadLine();
                Console.WriteLine(" ");

                switch (opcion)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("*****************************");
                        Console.WriteLine("Algunos ejemplos de Anfibios");
                        Console.WriteLine("*****************************");
                        Console.WriteLine("");
                        Console.WriteLine("1-Salamandra");
                        Console.WriteLine("2-Sapo");
                        Console.WriteLine("3-Triton");
                        Console.WriteLine("");
                        Console.Write("Selecciona la opcion del animal que deseas ver: ");
                        string op1 = Console.ReadLine();

                        switch (op1)
                        {
                            case "1":
                            rn.Salamandra();
                            break;
                            case "2":
                            rn.Sapo();
                            break;
                            case "3":
                            rn.Triton();
                            break;
                            default:
                            break;
                        }
                    break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("*****************************");
                        Console.WriteLine("Algunos ejemplos de Aves");
                        Console.WriteLine("*****************************");
                        Console.WriteLine("");
                        Console.WriteLine("1-Aguila Real");
                        Console.WriteLine("2-Gallina");
                        Console.WriteLine("3-Loro");
                        Console.WriteLine("");
                        Console.Write("Selecciona la opcion del animal que deseas ver: ");
                        string op2 = Console.ReadLine();
                        switch (op2)
                        {
                            case "1":
                            rn.Aguila();
                            break;
                            case "2":
                            rn.Gallina();
                            break;
                            case "3":
                            rn.Loro();
                            break;
                            default:
                            break;
                        }
                        
                    break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("*****************************");
                        Console.WriteLine("Algunos ejemplos de Mamiferos");
                        Console.WriteLine("*****************************");
                        Console.WriteLine("");
                        Console.WriteLine("1-Perro");
                        Console.WriteLine("2-Gato");
                        Console.WriteLine("3-Vaca");
                        Console.WriteLine("4-Ballena");
                        Console.WriteLine("");
                        Console.Write("Selecciona la opcion del animal que deseas ver: ");
                        string op3 = Console.ReadLine();

                        switch (op3)
                        {
                            case "1":
                            rn.Perro();
                            break;
                            case "2":
                            rn.Gato();
                            break;
                            case "3":
                            rn.Vaca();
                            break;
                            case "4":
                            rn.Ballena();
                            break;
                            default:
                            break;
                        } 
                    break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("*****************************");
                        Console.WriteLine("Algunos ejemplos de Peces");
                        Console.WriteLine("*****************************");
                        Console.WriteLine("");
                        Console.WriteLine("1-Piraña");
                        Console.WriteLine("2-Barracuda");
                        Console.WriteLine("3-Atun");
                        Console.WriteLine("");
                        Console.Write("Selecciona la opcion del animal que deseas ver: ");
                        string op4 = Console.ReadLine();

                        switch (op4)
                        {
                            case "1":
                            rn.Piraña();
                            break;
                            case "2":
                            rn.Barracuda();
                            break;
                            case "3":
                            rn.Atun();
                            break;
                            default:
                            break;
                        }
                    break; 
                    case "5"   :
                        Console.Clear();
                        Console.WriteLine("*****************************");
                        Console.WriteLine("Algunos ejemplos de Aves");
                        Console.WriteLine("*****************************");
                        Console.WriteLine("");
                        Console.WriteLine("1-Anaconda");
                        Console.WriteLine("2-Dragon de Komodo");
                        Console.WriteLine("3-Camaleon");
                        Console.WriteLine("");
                        Console.Write("Selecciona la opcion del animal que deseas ver: ");
                        string op5 = Console.ReadLine();
                            switch (op5)
                            {   
                                case "1":
                                rn.Anaconda();
                                break;
                                case "2":
                                rn.Dragon();
                                break;
                                case "3":
                                rn.Camaleon();
                                break;
                                default:
                                break;
                            }
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
