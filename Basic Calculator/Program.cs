using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to the calculator");
            Console.Write("\nPlease enter your first number: ");
            string num1 = Console.ReadLine();
            Console.Write("\nPlease enter your second number: ");
            string num2 = Console.ReadLine();

            double number1 = 0;
            double number2 = 0;
            try
            {
                number1 = Convert.ToDouble(num1);
                number2 = Convert.ToDouble(num2);
            }
            catch
            {
                Console.WriteLine("\nPlease enter numbers ONLY !!!");
                Console.WriteLine("\nAborting program... Press any key to exit");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("\nWhat type of operation would you like to do?");
            Console.WriteLine("\nPlease enter 'a' for additon, 's' for subtraction, 'm' for multiplication or 'd' for division.");
            string answer = Console.ReadLine();
            var result = answer == "a" ? number1 + number2 : answer == "s" ? number1 - number2 : answer == "m" ? number1 * number2 : number1 / number2;
            Console.WriteLine("\nResult: " + result);
            Console.ReadKey();
        }
    }
}
