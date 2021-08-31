using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Librarry
    {
        public static readonly int maximum_number_of_books;
        public static int number_of_available_books;

        private static List<Book> books;

        public static class Librarian
        {
            public static void AddBook(Book book)
            {
                if (number_of_available_books != maximum_number_of_books)
                {
                    books.Add(book);
                    number_of_available_books++;
                }
            }

            public static void DeleteBook(string title, string author)
            {
                for(int i = 0; i < number_of_available_books; ++i)
                {
                    if (books[i].title == title && books[i].author == author)
                    {
                        books.RemoveAt(i);
                        break;
                    }
                }
                number_of_available_books--;
            }

            public static void DeleteBooksByAuthor(string author)
            {
                for (int i = 0; i < number_of_available_books; ++i)
                {
                    if (books[i].author == author)
                    {
                        books.RemoveAt(i);
                        i--;
                        number_of_available_books--;
                    }
                }
            }

            public static void DeleteBooksByGenre(string genre)
            {
                for (int i = 0; i < number_of_available_books; ++i)
                {
                    if (books[i].genre == genre)
                    {
                        books.RemoveAt(i);
                        i--;
                        number_of_available_books--;
                    }
                }
            }

            public static void SearchByAuthor(string author)
            {
                bool search = false;
                foreach (var elem in books)
                {
                    if (elem.author == author)
                    {
                        search = true;
                        elem.ShowBookInfo();
                    }
                }
                if (!search) Console.WriteLine("The book was not found");
            }

            public static void SearchByGenre(string genre)
            {
                bool search = false;
                foreach (var elem in books)
                {
                    if (elem.genre == genre)
                    {
                        search = true;
                        elem.ShowBookInfo();
                    }
                }
                if (!search) Console.WriteLine("The book was not found");
            }

            public static Book SearchSpecificBook(string title, string author)
            {
                for (int i = 0; i < number_of_available_books; ++i)
                {
                    if (books[i].title == title && books[i].author == author)
                        return books[i];
                }
                return null;
            }

        }

        static Librarry()
        {
            books = new List<Book>();
            maximum_number_of_books = 100;
            number_of_available_books = 0;
        }

        public static void ShowAllBooks()
        {
            foreach(var elem in books)
            {
                elem.ShowBookInfo();
            }
        }

    }
}
