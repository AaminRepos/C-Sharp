using System;
using System.Text;
using System.Collections;
using System.Threading.Tasks;



namespace expMethod
{
    class program
    {


        static void Main(string[] args)
        {

            Console.WriteLine(Getpow(3,3));


            Console.WriteLine();

        }


        static int Getpow(int basenum, int pownum)
        {
            int result = 1;

            for (int i = 0; i < pownum; i++)
            {
                result = result * basenum;
            }
            return result;
        }

    }
    
}