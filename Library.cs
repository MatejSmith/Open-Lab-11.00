using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_11._00
{
    class Library
    {
        int numberOfBooks = 2;
        int numberOfStudents = 2;
        public List<string> studentsList = new List<string>();
        public List<Book> booksList = new List<Book>();

        public void Print()
        {
            Console.WriteLine("pocet knih:" + numberOfBooks);
            Console.WriteLine("pocet studentov:" + numberOfStudents + "\n");

            foreach (string student in studentsList)
            {
                Console.WriteLine(student);
            }

            foreach (var book in booksList)
            {
                book.PrintAll();
            }
        }
    }
}
