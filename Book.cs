using System;
using System.Diagnostics.Eventing.Reader;

namespace Week3Lib
{
    internal Class Book ()
	{
		string Title;
		string Author;
		string ISBN;

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
            Book myBook = new Book();
			//This is the info about one book in this library
			myBook.Title = "C# For beginners";
			myBook.Author = "Bill Gates";
			myBook.ISBN = "12345";

            //Adding another Book
            Book myBook2 = new Book();
            myBook2.Title = "C# Methods and Classes";
            myBook2.Author = "Microsoft";
            myBook2.ISBN = "54321";

            //Output book information to the console
            myBook.DisplayInfo();
            myBook2.DisplayInfo();
        }
    }
    }
}
