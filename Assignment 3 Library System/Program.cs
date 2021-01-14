using System;

namespace Assignment_3_Library_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Book harryPotter = new Book("Harry Potter", "JK Rowling", 399);
            Console.WriteLine(Book.NumberOfBooks);

            Book theBible = new Book("The Bible", "Jesus Christ", 999);
            Console.WriteLine(Book.NumberOfBooks);

            Book nineteeneightyfour = new Book("1984", "George Orwell", 599);
            Console.WriteLine(Book.NumberOfBooks);

        }
    }
}
