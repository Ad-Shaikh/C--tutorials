using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace methods
    {
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("What is your name: ");
            string name = Console.ReadLine();
            Console.Write("What is your age: ");
            int age = Convert.ToInt32(Console.ReadLine();

            SayHi(name, age);
            
            Console.ReadLine();
        }

        static void SayHi(string name, int age)
        {
            Console.WriteLine($"Hello {name} Your age is {age}");
        }
    }

}
