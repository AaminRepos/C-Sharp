using System;
namespace Cs_Inheritance
{
	public class SushiChef : Chef
	{

        public void MakePasta()
        {
            Console.WriteLine("The chef is making Pasta!");
        }

        public void MakeSalmon()
        {
            Console.WriteLine("The chef is making Salmon Rolls!");
        }


        public void MakeWasabi()
        {
            Console.WriteLine("The chef is making Wasabi!");
        }

        public virtual void MakeEel()
        {
            Console.WriteLine("The chef is Making eel!");
        }

        public override void MakeDishDash() 
        {
            Console.WriteLine("The chef is running out!");
        }

        public SushiChef()
		{
		}
	}
}

