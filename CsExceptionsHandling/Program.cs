using System;
using System.Text;
using System.Collections;
using System.Threading.Tasks;


namespace handling
{
    class program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.Write("Please enter a numner: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Now enter another number please: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num1 / num2);

            }
            /*
             
            catch (Exception e)
            {
                Console.WriteLine("Error!");
                Console.WriteLine(" ");
                Console.WriteLine(e.Message);
            }

            */

            ///and+or//
            ///

            catch (DivideByZeroException x)
            {
                Console.WriteLine("Error!");
                Console.WriteLine(" ");
                Console.WriteLine(x.Message);
            }

            catch (FormatException z)
            {
                Console.WriteLine("Error!");
                Console.WriteLine(" ");
                Console.WriteLine(z.Message);
            }


            finally                   //will run no matter the error-type//
            {
                Console.WriteLine("THank you for USing SeCurists");
            }
            

            Console.ReadLine();
        }
    }
}