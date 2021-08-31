using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book
    {
        private static int BookObjectCount;
        public string title { get; }
        public string author { get; }
        public string genre { get; }
        public int page_number { get; }
        public int ID { get; }

        static Book()
        {
            BookObjectCount = 0;
        }

        public Book(string title, string author, string genre, int page_number)
        {
            this.title = title;
            this.author = author;
            this.genre = genre;
            this.page_number = page_number;
            BookObjectCount++;
            ID = BookObjectCount;
        }

        public Book(string title, int page_number) : this(title, "unknow", "", page_number) { }

        public Book(string title, string author, int page_number) : this(title, author, "", page_number) { }

        public void ShowBookInfo()
        {
            Console.Write($"\nID : {ID}\nTitle : {title}\nAuthor : {author}\nGenre : {genre}\nPageNumber : {page_number}\n");
        }
    }
}
