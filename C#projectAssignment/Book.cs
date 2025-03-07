using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_projectAssignment
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Isbn { get; set; }
        public Book()
        {
            Title = "unknown";
            Author = "unknown";
            Isbn = 0000;
        }
        public Book(string tit,string author)
        {
            Title = tit;
            Author=author;

        }
        public Book(string tit, string author,int isbn)
        {
            Title=tit;
            Author = author;
            Isbn = isbn;
            

        }
        public void Displaydetails()
        {
            Console.WriteLine("booktitle:" + Title);
            Console.WriteLine("bookAuthor:" + Author);
            Console.WriteLine("isbn number:"+Isbn);

        }
    }
}
