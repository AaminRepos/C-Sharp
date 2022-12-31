using System;
using System.Text;
using System.Linq;
using System.Collections;
using System.Threading.Tasks;


namespace Cs_Inheritance
{
    class program
    {
        static void Main(string[] args)
        {

            Chef chef = new Chef();

            chef.MakeChicken();
            Console.WriteLine(" ");

            chef.MakeDishDash();
            Console.WriteLine(" ");


            SushiChef chef2 = new SushiChef();

            chef2.MakeEel();
            Console.WriteLine(" ");


            chef2.MakeDishDash();
            Console.WriteLine(" ");


            chef2.MakePasta();
            Console.WriteLine(" ");


            Console.ReadLine();
        }

    }
}