using System.Text;
using System.Threading.Tasks;

namespace GetterAndSetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie1 = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Movie movie2 = new Movie("Shrek", "Adam Adamson", "PG");

            // G, PG, PG-13, R, NR

            Console.WriteLine(movie1.Rating);
            //Console.WriteLine(student2.HasHonors());
            Console.ReadLine();


        }
    }

}