namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                float result = (float)num1 / num2;

                Console.WriteLine($"The division of {num1}/{num2} is : {result}");
            }

            catch (DivideByZeroException d)
            {
                Console.WriteLine(d.Message);
            }
            catch(FormatException f) 
            {
                Console.WriteLine(f.Message);
            }
            
            Console.ReadLine();
        }

        
    }

}
