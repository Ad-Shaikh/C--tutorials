using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Return
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a num to be cubed: ");

            int num = Convert.ToInt32(Console.ReadLine());

            int result = cube(num);

            Console.WriteLine($"Result: {result}");

            Console.ReadLine();
        }
        static int cube(int num)
        {
            int result = num * num * num;
            return result;

        }
    }

}
