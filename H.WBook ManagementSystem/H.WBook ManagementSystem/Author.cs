using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Reflection.Metadata.BlobBuilder;

namespace H.WBook_ManagementSystem
{
    public class Author
    {
        public int BookId;
         string authorName;
         int birthYear;
        string nationality;
        public List<Book> book;
        // List<Book> book = new List<Book>();
        //public
        public string AuthorName
        {
            set { this.authorName = value; }
            get { return this.authorName; }
        }
        public int BirthYear
        {
            set { this.birthYear = value; }
            get { return this.birthYear; }

        }
        public string Nationality
        {
            set { this.nationality = value; }
            get { return this.nationality; }
        }

        public Author() {
            book = new List<Book>();

        }
        public Author(string _authorName, int _birthYear, string _nationality)
        {
            this.authorName = _authorName;
            this.birthYear = _birthYear;
            nationality = _nationality;
           

        }
        public void AddBookToAuthor(Book _book)
        {  
            book.Add(_book);    
        }

        public void displayAuthorInfo()
        {
            Console.WriteLine($" {authorName}\n {birthYear} \n {nationality} \n {book}");
           // Console.WriteLine($"{student.Name}'s Subjects:");
            /*foreach (var item in book)
            {
                Console.WriteLine(item);
            }*/
        }
    }
   
}
