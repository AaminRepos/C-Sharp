using System;
using System.Collections;
using System.Text;
using System.Threading.Tasks;


namespace loopy
{
    class program
    {
        static void Main(string[] args)
        {


            int[] luckyNumbers = {3,5,7,9,11,13};


            ///while loop///
            ///

            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine(i);
                i++;
            }



            /////for loop//
            ///



            for (int x = 0; x < luckyNumbers.Length; x++ )
            {
                Console.WriteLine(luckyNumbers[x]);

            }


            Console.ReadLine();
        }
    }
}

