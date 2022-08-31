using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones_básicas
{
    internal class Program
    {
        
        static void Main(string[] args) {

            //Declarar variables
            string firstName = "Bob";
            string resp;
            int r = 0, valor;
            int widgetsSold = 7;
            int fahrenheit = 94;
            int firstNumber = 12, secondNumber = 7;
            int sum = 7 + 5, difference = 7 - 5, product = 7 * 5, quotient = 7 / 5;
            int value1 = 3 + 4 * 5, value2 = (3 + 4) * 5;
            int value = 1;
            decimal decimalQuotient = 7.0m / 5;
            double celsius;
            double d = 5.00 / 9;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Primera parte: Suma de enteros");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("El resultado de 12 + 7 es");
            Console.WriteLine(firstNumber + secondNumber);
            Console.WriteLine(" ");
            Console.WriteLine("De click a ENTER");
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Segunda parte: Conversiones implicitas de int y string");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");
            Console.WriteLine(" ");
            Console.WriteLine("De click a ENTER");
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Tercera parte: Concatenación de caracteres");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");
            Console.WriteLine(" ");
            Console.WriteLine("De click a ENTER");
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Cuarta parte: Uso de parentesis");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");
            Console.WriteLine(" ");
            Console.WriteLine("De click a ENTER");
            Console.ReadLine();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Quinta parte: Operaciones básicas");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + difference);
            Console.WriteLine("Product: " + product);
            Console.WriteLine("Quotient: " + quotient);
            Console.WriteLine(" ");
            Console.WriteLine("De click a ENTER");
            Console.ReadLine();
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Sexta parte: Decimales");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Decimal quotient: " + decimalQuotient);
            Console.WriteLine(" ");
            Console.WriteLine("De click a ENTER");
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Septima parte: Restante de una división");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Modulus of 200 / 5 : " + (200 % 5));
            Console.WriteLine("Modulus of 7 / 5 : " + (7 % 5));
            Console.WriteLine(" ");
            Console.WriteLine("De click a ENTER");
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Octava parte: Orden de operaciones");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("3 + 4 * 5 = " + value1);
            Console.WriteLine("(3 + 4) * 5 = " + value2);
            Console.WriteLine(" ");
            Console.WriteLine("De click a ENTER");
            Console.ReadLine();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Novena parte: Aumento y disminución de un valor");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Gray;
            
            value = value + 1;
            Console.WriteLine("First increment: " + value);

            value += 1;
            Console.WriteLine("Second increment: " + value);

            value++;
            Console.WriteLine("Third increment: " + value);

            value = value - 1;
            Console.WriteLine("First decrement: " + value);

            value -= 1;
            Console.WriteLine("Second decrement: " + value);

            value--;
            Console.WriteLine("Third decrement: " + value);

            Console.WriteLine(" ");
            Console.WriteLine("De click a ENTER");
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Decima parte: Uso de operadores de incremento");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Gray;

            value++;
            Console.WriteLine("First: " + value);
            Console.WriteLine("Second: " + value++);
            Console.WriteLine("Third: " + value);
            Console.WriteLine("Fourth: " + (++value));

            Console.WriteLine(" ");
            Console.WriteLine("De click a ENTER");
            Console.ReadLine();
            Console.Clear();


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Desafio");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Gray;
            celsius = (fahrenheit - 32) * d;

            Console.WriteLine(fahrenheit + " grados Fahrenheit es igual a " + celsius + " grados Celsius");
            Console.WriteLine(" ");
            Console.WriteLine("De click a ENTER");
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Desafio 2.0");
            Console.WriteLine(" ");
            do
            {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Indica la temperatura en grados Fahrenheit para convertirla en Celsius (No se admite 0 o algun decimal)");
            resp = Console.ReadLine();

                if (int.TryParse(resp, out valor))
                {
                    r = Convert.ToInt32(resp);
                }
                else
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("No ha indicado alguna cantidad, o la cantidad que indicó es 0");
                    Console.WriteLine(" ");
                }

                
            } while (r ==0);
           
            celsius = (r - 32) * d;
            Console.WriteLine(" ");
            Console.WriteLine(resp + " grados Fahrenheit es igual a " + celsius + " grados Celsius");
            Console.WriteLine(" ");
            Console.WriteLine(" ENTER para salir de la consola");

            Console.ReadLine();
        }
    }
}