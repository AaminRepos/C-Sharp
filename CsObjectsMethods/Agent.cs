using System;
namespace CsObjectsMethods
{
	public class Agent
	{
		public string? name;
		public string? dept;
		public double gpa;

		public Agent(string aName,string aDept, double aGPA )
		{
			name = aName;
			dept = aDept;
			gpa = aGPA;
		}

		public bool HasHonors()
		{
			if (gpa >= 3.5)
			{
				return true;
			}
			return false;
		}
	}

}

