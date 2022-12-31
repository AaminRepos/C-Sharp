using System;
using System.Text;
using System.Linq;
using System.Collections;
using System.Threading.Tasks;

namespace CsObjectsMethods
{
    class program
    {
        static void Main(string[] args)
        {

            Agent agent1 = new Agent("josh", "accounting", 3.7);

            Agent agent2 = new Agent("jim", "sales", 3.2);

            Console.WriteLine(agent1.HasHonors());

            Console.WriteLine("");

            Console.WriteLine(agent2.HasHonors());



            Console.ReadLine();
        }
    }
}

