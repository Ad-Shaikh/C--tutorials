using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 1;
            while (index<=5)
            {
                Console.WriteLine(index);
                index++;

            }

            int index2 = 6;
            do
            {   
                Console.WriteLine("");
                Console.WriteLine(index2);
                index++;
            }while(index2<=5);
            Console.ReadLine();

        }

    }

}
