namespace TwoDArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numGrid =
            {
                {1,2}, 
                {3,4}, 
                {5,6}
            };

            int[,] MyArray = new int[2,3];

            Console.WriteLine(numGrid[0,0]);
            Console.WriteLine(MyArray[0,0]);
                        
            Console.ReadLine();
        }

        
    }

}
