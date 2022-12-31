using System;
namespace Cs_Inheritance
{
	public class Chef
	{
		public void MakeChicken()
		{
			Console.WriteLine("The chef is making chicken!");
		}


		public void MakeSalad()
		{
			Console.WriteLine("The chef is making salad!");
		}

		public virtual void MakeDishDash() //method can be over written in sub classes
		{
			Console.WriteLine("The chef is dashing out!");
		}


		public Chef()
		{
		}
	}
}

