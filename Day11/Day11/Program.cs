namespace Day11
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* Console.WriteLine(" Enter First name ");
            string name =Console.ReadLine();
            Console.WriteLine( " Enter Last name ");
            string Last = Console.ReadLine();
            Console.WriteLine(" Enter Email ");
            string Email = Console.ReadLine();
          
            int age;
            string Sage;
        
            do
            {
                Console.WriteLine(" Enter valid Age ");
                Sage = Console.ReadLine();
                int.TryParse(Sage, out age);

            } while (age <= 18 || age>=100);

            Human _human = new Human(name, Last, Email, age);*/

          // Human _human1 = new Human {FirstName = "Mohammed", LastName = "Alabri" };
           // _human1.Print();
          
            Human _human2 = new Human ("A","last","Email",8);
            Human _human3 = new Human("B", "last", "Email@hotmail", 8);
            Human _human4 = new Human("C", "last", "Email@gmail", 8);
            Console.WriteLine(_human2.getiD());
            Console.WriteLine(_human2.getEmai());
            _human2.SetEmai("ALe@");
            Console.WriteLine(_human2.getEmai());
          //  _human2.Print();
         
            Human[]EM = new Human[] {_human2, _human3, _human4};
            foreach(Human em in EM)
            {
                em.Print();
            }
        }

        public static int funLam(int x, int y) => x * y;
        
    }
}