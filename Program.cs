using System;
using System.Collections.Generic;

namespace Open_Lab_11._00
{
    class Program
    {
        static void Main(string[] args)
        {
            Library schoolLibrary = new Library();
            schoolLibrary.studentsList.Add("Poul");
            schoolLibrary.booksList.Add(new Book("biologia pre 5. rocnik", 108, Book.categoryList[2], "Mária Uhereková", 2014));

            schoolLibrary.studentsList.Add("John");
            schoolLibrary.booksList.Add(new Book("vlastiveda pre 4. rocnik", 88, Book.categoryList[2], "Mária Šimunková", 2014));

            schoolLibrary.Print();
            Console.ReadLine();
        }
    }
}
