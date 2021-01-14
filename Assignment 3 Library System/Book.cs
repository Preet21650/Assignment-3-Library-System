using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_3_Library_System
{
    class Book
    {
        private string title;
        private string author;
        private int pages;
        private bool borrowed;

        public static int NumberOfBooks = 0;
            
        public Book(string title, string author, int pages)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
            this.borrowed = false;

            NumberOfBooks = NumberOfBooks + 1;

        }
        public string GetTitle()
        {
            return title;
        }

        public string GetAuthor()
        {
            return author;
        }
        public int GetPages()
        {
            return pages;
        }
        public bool isBorrowed()
        {
            return borrowed;
        }

        public void BorrowBook()
        {
            if (borrowed == false)
            {
                borrowed = true;

            }
            else
            {
                Console.WriteLine(title + "is not available");
            }
                    
        }
        public void ReturnBook()
        {
            if(borrowed == true)
            {
                borrowed = false;
            }
            else
            {
                Console.WriteLine(title);
            }
        }
    }
}
