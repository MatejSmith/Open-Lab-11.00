using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_11._00
{
    class Book
    {
        private string title { get; set; }
        private int pages { get; set; }
        private string category { get; set; }
        private string author { get; set; }
        private int releaseDate { get; set; }
        private string newLine = Environment.NewLine;
        /// <summary>
        /// vytvorili sme list a pridali sme don kategorie
        /// </summary>
        public static List<string> categoryList = new List<string> { "detske", "romanticke", "naucne", "scifi", "doubrodruzne", "detektivka" };

        public Book()
        {
            title = "-1";
            pages = -1;
            category = "-1";
            author = "-1";
            releaseDate = -1;
        }

        public Book(string title, int pages)
        {
            this.title = title;
            this.pages = pages;
            category = "-1";
            author = "-1";
            releaseDate = -1;
        }

        public Book(string title, int pages, string category, string author, int releaseDate)
        {
            this.title = title;
            this.pages = pages;
            this.category = category;
            this.author = author;
            this.releaseDate = releaseDate;
        }
        public void PrintAll()
        {
            Console.WriteLine($"{title} {pages} {category} {author} {releaseDate}");
        }
    }
}