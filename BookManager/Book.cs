using System;
using System.Collections.Generic;
using System.Text;

namespace BookManager
{
    class Book
    {
        private string title;
        private string author;
        private int pages;
        private int wordCount ;

        private static int totalBooks;

        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
            totalBooks++;
        }        public static int GetTotalBooks() => totalBooks;        static Book()        {
            totalBooks = 0;
        }        public string GetTitle()
        {
            return title;
        }

        public void SetTitle(string title)
        {
            if (title != null && title.Length > 0)
                this.title = title;
        }

        public void SetAuthor(string author)
        {
            if (author != null && author.Length > 0)
                this.author = author;
        }

        public int GetTitleLength()
        {
            return title.Length;
        }

        public void AssignWordCountFromText(string text)
        {
            wordCount = text.Split(" ").Length;
        }
    }
}
