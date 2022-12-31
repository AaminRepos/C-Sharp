using System;
using System.Text;
using System.Collections;
using System.Threading.Tasks;


namespace matrices
{
    class program
    {
        static void Main(string[] args)
        {

            int[,] numberGrid = {
                { 1,3,6},
                { 9,11,13},
                { 15,17,19}
            };
            Console.WriteLine("");




            Console.WriteLine(numberGrid[0,0]);
            Console.WriteLine("");

            Console.WriteLine("     " + numberGrid[1, 1]);
            Console.WriteLine("");

            Console.WriteLine("            " + numberGrid[2, 2]);
            Console.WriteLine("");



            int[,] emptyArray = new int[3, 3]; /// is how to create and empyt array
                                               /// [3,3] is the shapw of the 2nd-dim array


            Console.ReadLine();
        }
    }
}
