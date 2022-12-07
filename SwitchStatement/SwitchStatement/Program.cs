using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the day number");
            int dayNum = Convert.ToInt32(Console.ReadLine());

            string day = GetDay(dayNum);
            Console.WriteLine($"{dayNum} is {day}");

            Console.ReadLine();
        }

        static string GetDay(int dayNum)
        {
            string dayName="";

            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;

                case 1:
                    dayName = "Monday";
                    break;

                case 2:
                    dayName = "Tuesday";
                    break;

                case 3:
                    dayName = "Wednesday";
                    break;

                case 4:
                    dayName = "Thursday";
                    break;

                case 5:
                    dayName = "Friday";
                    break;

                case 6:
                    dayName = "Saturday";
                    break;

                default:
                    Console.WriteLine("Invalid number");
                    break;
            }

            return dayName;
        }
    }

}
