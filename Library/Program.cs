using System;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        { 
            Librarry library = new Librarry();
            Librarry.Librarian.AddBook(new Book("Spanutyun Aybenakan Kargov","Agata Qristi","Detektiv",256));
            Librarry.Librarian.AddBook(new Book("Spanutyun Golfi dashtum","Agata Qristi","Detektiv",320));
            Librarry.Librarian.AddBook(new Book("Spanutyun Arevelyan Chepntacum", "Agata Qristi", "Detektiv", 256));
            Librarry.Librarian.AddBook(new Book("Rodjer Aqroydi Spanutyun", "Agata Qristi", "Detektiv", 312));
            Librarry.Librarian.AddBook(new Book("Diak@ Gradaranum", "Agata Qristi", "Detektiv", 245));
            Librarry.Librarian.AddBook(new Book("Jamadrutyun Mahvan het", "Agata Qristi", "Detektiv", 256));
            Librarry.Librarian.AddBook(new Book("Anban Hurin", "Hovhannes Tumanyan", "Heqiat", 2));
            Librarry.Librarian.AddBook(new Book("Menutyan Xavar", "Vahan Terian", "Banastexcutyun", 1));
            Librarry.ShowAllBooks();
            Console.WriteLine("***************************************");
            Librarry.Librarian.SearchByGenre("Banastexcutyun");
            Librarry.Librarian.DeleteBooksByGenre("Detektiv");
            Librarry.Librarian.SearchByAuthor("Hovhannes Tumanyan");
            Librarry.ShowAllBooks();
            Console.WriteLine(Librarry.number_of_available_books);

            Console.ReadLine();
        }
    }
}
