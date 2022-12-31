using System;
using System.Text;
using System.Collections;
using System.Threading.Tasks;


namespace CsClassesAndObjecta
{
    class program
    {
        static void Main(string[] args)
        {
            /* classes and objects
            
           Book book2 = new Book();

           book2.title = "Tatsumaru";             <-------- without constructor
           book2.author = "shivavan Tatsumi";
           book2.pages = 369;

           Console.WriteLine(book2.title + " " + book2.author +
               " " + book2.pages);
           */

            //////class constructors///

            Book book1 = new Book("Rage", "Santi Porller", 289);

            Console.WriteLine(book1.title + " " + book1.author +
                " " + book1.pages);

            Console.WriteLine(" ");


   
            Console.ReadLine();
        }
    }
}