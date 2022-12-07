using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first num: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second num: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the operator: ");
            string op = Console.ReadLine();

            double result = Calc(num1, num2, op);

            Console.WriteLine($"Result is {result}");



            Console.ReadLine();
        }

        static double Calc(double num1, double num2, string op)
        {
            double result=0;

            if (op == "+")
            {
                result = num1+num2;
            }
            else if (op == "-")
            {
                result = num1-num2;
            }
            else if (op == "*")
            {
                result = num1 * num2;
            }
            else if (op == "/")
            {
                result = num1 / num2;
            }
            else
            {
                Console.WriteLine("Invalid Operator");
            }

            return result;
        }
    }

}