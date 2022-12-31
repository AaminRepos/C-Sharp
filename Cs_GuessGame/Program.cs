using System;
using System.Collections;
using System.Text;
using System.Threading.Tasks;


namespace GuessGame
{
    class program
    {
        static void Main(string[] args)
        {

            string key = "free";
            string guess = "";
            int guessCount = 0;
            int gLimit = 6;
            bool outofGs = false;

            Console.WriteLine("A price with no numbers.");
            Console.WriteLine("");
            Console.WriteLine("A block of four stones.");
            Console.WriteLine("");
            Console.WriteLine("A one in time you shall become..");
            Console.WriteLine("");

            while (guess != key && !outofGs)
            {
                if (guessCount < gLimit)
                {
                    Console.Write("Enter your guess please: ");

                    guess = Console.ReadLine();

                    guessCount++;
                }

                else
                {
                    outofGs = true;
                }

            }


            if (outofGs)

            {
                    Console.Write("BAD G..good time");
            }

            else
            {
                Console.WriteLine("Good JOb");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Khufu, Ra comes from the west...");


            }


            Console.ReadLine();
        }
    }
}