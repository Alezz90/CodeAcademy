namespace H.WBook_ManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");
            List<Author> author = new List<Author>();
            List<Book> books = new List<Book>();
            while (true)
            {
                Console.WriteLine("what you want to do ? 1. Add new Author 2.Add new book? 3.display Author books?  ");

                int n;
                do
                {
                    Console.WriteLine("Please enter a valid number.");
                }
                while (!int.TryParse(Console.ReadLine(), out n) && (n < 0 || n > 3));

                string name = "";
                int AutherYear = 0; ;
                string Natonality = "";
                // Author A1 = new Author(name, AutherYear, Natonality);
              

                switch (n)
                {
                    case 1:
                        Console.WriteLine(("Enter Auther name"));
                        name = Console.ReadLine();
                        Console.WriteLine(("Enter Auther Year of birth"));

                        while (!int.TryParse(Console.ReadLine(), out AutherYear))
                        {
                            Console.WriteLine("Please enter a valid year.");
                        }


                        Console.WriteLine(("Enter Auther Nationality"));
                        Natonality = Console.ReadLine(); ;
                        Author _author = new Author(name, AutherYear, Natonality);
                        author.Add(_author);
                        _author.displayAuthorInfo();
                        
                        break;
                    case 2:
                        Console.WriteLine(("Enter Book name"));
                        name = Console.ReadLine();
                        Console.WriteLine(("Enter Book Year of Bublish"));
                        while (!int.TryParse(Console.ReadLine(), out AutherYear))
                        {
                            Console.WriteLine("Please enter a valid year.");
                        }
                        Console.WriteLine(("Enter gen"));
                        Natonality = Console.ReadLine();

                      //  Book _book1 = new Book();
                      //  _book1.AList(name, AutherYear, Natonality);
                        Book _book = new Book(name, AutherYear, Natonality);
                        books.Add(_book);
                        Console.WriteLine("Enter Auther name");
                        string Aname = Console.ReadLine();
                        
                        bool authorFound = false;
                        foreach (Author item in author)
                        {
                            if (Aname == item.AuthorName)
                            {
                                Author author1 = new Author();
                                author1.AddBookToAuthor(_book);
                                authorFound= true;
                                break;
                            }
                              
                            // _author.AddBookAuthor(_book);
                        }
                        if (authorFound == false)
                        {
                            Console.WriteLine("author invalid");
                        }
                        
                        //author.Add(_book);
                        break;
                    case 3:
                        foreach (Author item in author)
                        {
                            item.displayAuthorInfo();
                        }
                        break;

                }
            }

        }



    }
}