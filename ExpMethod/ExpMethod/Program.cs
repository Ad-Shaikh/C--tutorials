namespace ExpMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the base of the number: ");
            int baseNnum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the power of the number: ");
            int powNnum = Convert.ToInt32(Console.ReadLine());

            int result = GetPow(baseNnum, powNnum);

            Console.Write($"The result of {baseNnum}^{powNnum} is : {result}");

            Console.ReadLine();
        }

        static int GetPow ( int baseNum, int powNum)
        {
            int result = 1;

            for (int i =0; i < powNum; i++)
            {
                result *= baseNum;
            }

            return result;
        }

    }

}
