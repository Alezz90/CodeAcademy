namespace Day3
{
     struct Program
    {
        static void Main()
        {
            int x = Convert.ToInt32(Console.ReadLine()) ;
            int y = x % 3;
            string result = (y == 0) ? "yes it divisible" : "not disible";
            Console.WriteLine(result);
        }
    }
}