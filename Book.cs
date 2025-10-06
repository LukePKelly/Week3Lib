using System;
using System.Diagnostics.Eventing.Reader;

namespace Week3Lib
{
    internal class Book ()
	{
		string Title;
		string Author;
		string ISBN;

         public Book(string bookTitle, string bookAuthor, string bookISBN)
        {
              Title = bookTitle;
              Author = bookAuthor;
              ISBN = bookISBN;
        }

        void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }


         static void Main(string[] args)
		{
            //Creates a new instance of the Book class, object name differs from the class name
            Book myBook = new Book("C# For beginners", "Bill Gates", "12345");
			
            //Adding another Book
            Book myBook2 = new Book("C# Methods and Classes" "Microsoft", "54321");
 
            //Output book information to the console
            myBook.DisplayInfo();
            myBook2.DisplayInfo();
        }
    }
    }
}
