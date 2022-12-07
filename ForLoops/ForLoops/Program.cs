using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Enter no of elements in the array: ");
            int len=Convert.ToInt32(Console.ReadLine());
            int[] luckyNumbers = new int[len];

            for (int j=0; j< luckyNumbers.Length; j++)
            {
                Console.WriteLine($"Enter {j} Element of the list");
                luckyNumbers[j] = Convert.ToInt32(Console.ReadLine());
            }
            
            for (int i = 0; i <luckyNumbers.Length; i++)
            {
                Console.WriteLine($"Lucky number {i+1} is {luckyNumbers[i]}");
            }
            Console.ReadLine();
        }

    }

}
