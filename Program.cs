using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_OperatorsPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arithmetic Operations Demo
            int number1, number2, plus, minus, product, divide;
            number1 = 60;
            number2 = 40;
            //we can take int as well as var also it will store the addition
            var addition = number1 + number2;
            plus = number1 + number2;
            Console.WriteLine("The addition of two numbers is = " + addition);
            Console.WriteLine("The addition of two numbers is = " + plus);

            //This code is to minus of two numbers
            minus = number1 - number2;
            Console.WriteLine("The equaition is = " + minus);

            //This code is to show product of two numbers
            product = number1 * number2;
            Console.WriteLine("The product is = " + product);

            //This code is to show dividation of tow numbers
            divide = number1 / number2;
            Console.WriteLine("The divide is = "+ divide);
            Console.ReadKey();
        }
    }
}
