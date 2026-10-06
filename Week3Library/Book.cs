using System;
using System.Collections.Generic;
using System.Text;

namespace Week3Library
{
    public class Book
    {

        // private field
        private string title;
        private string author;
        private int isbn;

        // public properties
        public string Title
        {
            get { return title; }
            set { title = value; }
                    }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public int ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }

        // constructor
        public Book(string bookTitle, string bookAuthor, int bookISBN)
        {
            Title = bookTitle;
            Author = bookAuthor;
            ISBN = bookISBN;
        }

        // methods
        public void DisplayInfo()
        {
            Console.WriteLine($"Book Title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }

        //paramaterised constructor



    }
}
