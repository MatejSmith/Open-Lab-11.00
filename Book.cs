using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_10._00
{
    class Book
    {
        private string title;
        private int pages;
        private string category;
        private string author;
        private int releaseDate;
        public string newLine = Environment.NewLine;
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

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        public int Pages
        {
            get
            {
                return pages;
            }
            set
            {
                if (value > 0)
                {
                    pages = value;
                }
                else
                {
                    pages = 1;
                }
            }
        }

        public string Category
        {
            set
            {
                category = value;
            }
        }

        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }

        public int ReleaseDate
        {
            get
            {
                return releaseDate;
            }
            set
            {
                if (value < 2021 && value > 1450)
                {
                    releaseDate = value;
                }
                else
                {
                    releaseDate = -1;
                }

            }
        }
        public override string ToString()
        {
            return "Nazov: " + title + newLine + "Pocet stran: " + pages + newLine + "Zaner: " + category + newLine + "Autor: " + author + newLine + "Datum vydania: " + releaseDate;
        }
    }
}