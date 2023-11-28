using System.Transactions;

namespace Day6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*   Console.WriteLine("Enter Lenght of Pattern ");
               int Lenght = Convert.ToInt32(Console.ReadLine());

               Console.WriteLine("Enter Lenght of Flag true or false");
              bool Flag = Convert.ToBoolean(Console.ReadLine());
               Console.WriteLine("Enter Pattren");
               String pattern = Console.ReadLine();
               FlagFun(pattern, Flag, Lenght);*/
          
            int x = 5;
            int y = 1;

            Console.WriteLine($"Origin{x},{y}");
            swap(x, y);
            REswap(ref x, ref y);
            Console.WriteLine($"Refranced out{x},{y}");

        }
        /* static void FlagFun ( string pattern,bool Flag, int x)
         {
             if (Flag == true)
             {
                 for (int i = 1; i < x; i++)
                 {
                     Console.WriteLine(pattern);
                 }
             }
             else if (Flag == false)
             {
                 for (int i = 1; i < x; i++)
                 {
                     Console.Write(pattern);
                 }
             }*/
        static void swap(int x, int y)  {
            int temp = x;
            x = y;
            y = temp;
            Console.WriteLine($"swap {x},{y}");
        }
        static void REswap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
            Console.WriteLine($"Refranced In side {x},{y}");

        }
    }
}