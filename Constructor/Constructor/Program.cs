using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Harry Potter", "JK Rowling", 400);
            Book book2 = new Book("Lord Of the Rings", "Toklein", 700);
            
            Book book3 = new Book();
            

            Console.WriteLine($"1. {book1.title}");
            Console.WriteLine($"2. {book2.title}");
            Console.ReadLine();
        }


    }

}
