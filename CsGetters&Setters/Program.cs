using System;
using System.Text;
using System.Linq;
using System.Collections;
using System.Threading.Tasks;

namespace CsGetters_Setters
{
    class program
    {
        static void Main(string[] args)
        {

            Movie ironman = new Movie("Iron Man", "Tony Stark", "dog");
            Movie matrix = new Movie("The Matrix", "Neo", "M-17");
            Console.WriteLine("");

            Console.WriteLine(ironman.Rating);
            Console.WriteLine("");

            Console.WriteLine(matrix.Rating);
            Console.WriteLine("");


            Console.ReadLine();
        }
           
    }
}
