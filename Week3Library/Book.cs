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
            set
            {
                title = value;
                { // check if any incoming chair is a digit
                    if (!value.Any(char.IsDigit))
                    {
                        title = value;
                    }
                    else
                    {
                        Console.WriteLine("Cannot enter number for title");
                    }
                }
            }
        }

        public string Author
        {
            get { return author; }
            set
            {
                // Checks if any character in the incoming string is a digit
                if (!value.Any(char.IsDigit))
                {
                    author = value;
                }
                else
                {
                    Console.WriteLine("Error: Author name cannot contain numbers.");
                }
            }
        }

        public int ISBN
        {
            get { return isbn; }
            set
            {
                // Checks that the incoming string is not blank
                if (value != 0)
                {
                    isbn = value;
                }
                else
                {
                    Console.WriteLine("Error: ISBN cannot be blank.");
                }
            }
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
