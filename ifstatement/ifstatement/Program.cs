using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ifstatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first num:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second num:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the third num:");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int max= GetMax(num1, num2, num3);

            Console.WriteLine($"Maximum Number is {max}");
            
            
            
            Console.ReadLine();
        }

        static int GetMax(int num1, int num2,int num3)
        {
            int result;

            if (num1>=num2 && num1>=num3)
            {
                result = num1;
            }
            else if(num2>=num1 && num2>=num3)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }

            return result;
        }
    }

}