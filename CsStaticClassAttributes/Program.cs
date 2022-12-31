using System;
using System.Text;
using System.Linq;
using System.Collections;
using System.Threading.Tasks;

namespace CsStaticClassAttributes
{
    class program
    {
        static void Main(string[] args)
        {

            Song jonylah = new Song("Jonylah Forever", "Lupe Fiasco", 226);
            Console.WriteLine(Song.songCount);

            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
            Console.WriteLine(Song.songCount);

            Console.WriteLine(" ");


            Console.WriteLine(kashmir.getSongCount());

            Console.ReadLine();
        }

    }
}