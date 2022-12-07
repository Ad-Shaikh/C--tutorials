using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;
            
            Book book2 = new Book();
            book2.title = "Lord Of the Rings";
            book2.author = "Toklein";
            book2.pages = 700;
            
            Console.WriteLine($"1. {book1.title}");
            Console.WriteLine($"2. {book2.title}");
            Console.ReadLine();
        }


    }

}
