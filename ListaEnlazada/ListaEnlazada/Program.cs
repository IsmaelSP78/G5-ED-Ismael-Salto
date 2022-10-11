using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ListaEnlazada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista_Enlazada le = new Lista_Enlazada();
            int t = 0, opcion = 0, pos, value;
            string test, test2;
            bool pass = true;

           
            Console.ForegroundColor = ConsoleColor.Green;

            do
            {

                Console.Clear();
                do
                {
                    Console.Clear();
                    Console.SetCursorPosition(50, 0);
                    Console.WriteLine("Menu");
                    Console.SetCursorPosition(35, 1);
                    Console.WriteLine("1. Agregar una nueva cabeza a la lista");
                    Console.SetCursorPosition(35, 2);
                    Console.WriteLine("2. Agregar una nueva cola a la lista");
                    Console.SetCursorPosition(35, 3);
                    Console.WriteLine("3. Agregar un dato de una posición especifica");
                    Console.SetCursorPosition(35, 4);
                    Console.WriteLine("4. Eliminar un dato");
                    Console.SetCursorPosition(35, 5);
                    Console.WriteLine("5. Eliminar toda la lista");
                    Console.SetCursorPosition(35, 6);
                    Console.WriteLine("6. Consultar datos");
                    Console.SetCursorPosition(35, 7);
                    Console.WriteLine("7. Salir");

                    Console.SetCursorPosition(35, 9);
                    Console.WriteLine("¿Qué acción desea realizar?");
                    Console.SetCursorPosition(35, 10);
                    test = Console.ReadLine();

                    if (int.TryParse(test, out value))
                    {
                        opcion = Convert.ToInt32(test);
                        if (opcion > 7 || opcion <= 0)
                        {
                            
                            Console.WriteLine("Esta no es una opción valida. Presione ENTER");
                            Console.ReadLine();
                        }   
                    }
                    else {
                        opcion = -1;
                        Console.WriteLine("Esta no es una opción valida. Presione ENTER");
                        Console.ReadLine();
                    }
                    

                } while (opcion > 7 && opcion <= 0);


                switch (opcion)
            {
                case 1:
                        //Agregar cabeza
                        do
                        {

                        Console.Clear();
                            Console.SetCursorPosition(35, 1);
                            Console.WriteLine("Escribe 1 numero");
                            Console.SetCursorPosition(35, 2);
                            test = Console.ReadLine();

                        if (int.TryParse(test, out value))
                        {
                            t = Convert.ToInt32(test);
                            node newnode = new node();
                            newnode.data = t;
                            le.addhead(newnode);
                                pass = true;
                        }
                        else
                        {
                                Console.SetCursorPosition(35, 4);
                                Console.WriteLine("El dato escrito no es valido");
                            Console.ReadLine();
                                pass = false;
                        }
                        } while (pass != true);

                        break;

                case 2:
                        //Agregar Cola
                        do
                        {
                            Console.Clear();
                            Console.SetCursorPosition(35, 1);
                            Console.WriteLine("Escribe 1 numero");
                            Console.SetCursorPosition(35, 2);
                            test = Console.ReadLine();

                            if (int.TryParse(test, out value))
                            {
                                t = Convert.ToInt32(test);
                                node n = new node();
                                n.data = t;
                                le.addcola(n);
                                pass = true;
                            }
                            else
                            {
                                Console.SetCursorPosition(35, 4);
                                Console.WriteLine("El dato escrito no es valido");
                                Console.ReadLine();
                                pass = false;
                            }
                        } while (pass != true);
                        break;

                case 3:
                        do
                        {
                            Console.Clear();
                            le.PrintList();
                            
                            Console.WriteLine("Escribe la posición donde deseas colocar el nodo");
                            test = Console.ReadLine();
                           
                            Console.WriteLine("Escribe 1 numero que poner en el nodo");
                            test2 = Console.ReadLine();

                            if (int.TryParse(test, out value) && int.TryParse(test2,out value))
                            {

                                t = Convert.ToInt32(test2);
                                pos = Convert.ToInt32(test);
                                le.addInGivenPosition(t, pos);
                                pass = true; 
                            }
                            else
                            {
                                Console.WriteLine("El dato escrito no es valido");
                                Console.ReadLine();
                                pass = false;
                            }
                        } while (pass != true);
                        break;

                case 4:
                        do
                        {
                            Console.Clear();
                            le.PrintList();
                            Console.WriteLine("Escribe la posición que deseas eliminar");
                            test = Console.ReadLine();

                            if (int.TryParse(test, out value))
                            {
                                pos = Convert.ToInt32(test);
                                Console.Clear();
                                le.removeOneNode(pos);
                                pass = true;
                            }
                            else
                            {
                                Console.WriteLine("El dato escrito no es valido");
                                Console.ReadLine();
                                pass = false;
                            }
                        } while (pass != true);

                        break;

                case 5:
                        Console.Clear();
                        le.removeAll();
                        Console.WriteLine("La lista ya ha sido borrada");
                        Console.Read();
                        break;

                    case 6:
                        Console.Clear();
                        le.PrintList();
                        Console.ReadLine();
                        break;

                        case 7:
                        Console.Clear();
                        Console.SetCursorPosition(35, 1);
                        Console.WriteLine("Saliendo...");
                        Console.SetCursorPosition(35, 2);
                        Console.WriteLine("Presione ENTER");
                        break;
            }

        } while (opcion != 7);

            Console.ReadLine();
        }
    }
}
