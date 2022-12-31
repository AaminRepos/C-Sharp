using System;
namespace CsStaticClassAttributes
{
	public class Song
	{
		public string? title;
		public string? artist;
		public int length;

		public static int songCount = 0;

		public Song(string aTitle, string aArtist, int aLength)
		{
			title = aTitle;
			artist = aArtist;
			length = aLength;

			songCount++;
		}

		public int getSongCount()
		{
			return songCount;
		}
	}
}

