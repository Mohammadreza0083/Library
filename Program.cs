namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our Library");
            Library library = new Library();
            library.AddBook("deep work", "Cal Newport");
            library.AddBook("To Kill a Mockingbird", "Harper Lee");
            library.AddBook("1984", "George Orwell");
            library.AddBook("Graphic", "Mohammadreza");
            library.AddBook("atelaey nadarm", "testy");
            library.DisplayBooks();
            library.RegisterMember("mamad");
            library.RegisterMember("ghazanfar");
            library.BorrowBook("mamad", 2);
            library.DisplayBooks();
            library.ReturnBook("mamad", 2);
            library.DisplayBooks();
            Console.WriteLine("Have a nice day ");
            Console.WriteLine("press enter to exite...");
            Console.ReadLine();

        }
    }
}