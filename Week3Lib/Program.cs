using Week3Lib;
class Program
{
    static void Main(string[] args)
    {
        //Creates a new instance of the Book class, object name differs from the class name
        Book book = new Book("C# For beginners", "Bill Gates", "12345");
        //Output book information to the console
        book.DisplayInfo();
    }
}
