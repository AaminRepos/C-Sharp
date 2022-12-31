using System;
namespace CsGetters_Setters
{
	public class Movie
	{
		public string? title;
		public string? hero;
		private string? rating;


		public Movie(string aTitle, string aHero,
			string aRating)
		{
			title = aTitle;
			hero = aHero;
			Rating = aRating;
		}


		public string? Rating
		{
			get
			{
				return rating;
			}
			set
			{
				if (value == "E" ||
                    value == "PG-13"||
                    value == "PG" ||
					value == "PG-13" ||
					value == "M-17" ||
					value == "R"||
                    value == "NR")
				{
					rating = value;
				}
				else
				{
					rating = "NR";
				}
			}
		}
	}

}

