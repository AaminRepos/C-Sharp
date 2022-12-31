using System;
namespace CsClassesAndObjecta
{
	public class Book
	{
        /// classes and objects//
        
       public string? title;
       public string? author;
       public int pages;

        /////consrtuctor//

        public Book(string aTitle, string aAuthor, int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
    }

}

