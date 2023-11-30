using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace H.WBook_ManagementSystem
{
    public class Book
    {
         public string Title;
         public int publicationYear;
         public string genre;
        public List<string> book;

        public Book()
        {
          //  book = new List<string>();
        }
        public Book(string Title, int publicationYear, string genre)
        {
            this.Title = Title;
            this.publicationYear = publicationYear;
            this.genre = genre;
        }

       /* public void AList(string title,int pub,string g)
        {
           
            Book b1 = new Book();
             b1.AddBook("Mathematics");
             b1.AddBook("1999");
            
        }
       /* public void AddBook(string _book)
        {
            book.Add(_book);
        }*/
       

    }
}
