namespace Day8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Multiplicaion());
        }
        static string Multiplicaion(int i = 2)
        {
            string s =" ";
            for (int j = 1; j <= i; j++)
            {
                // Console.WriteLine($"Table {j}");
                s += $"Table {j} \n";
                for (int k = 1; k<=10; k++)
                {
                    //Console.WriteLine($"{j}*{k} = {j * k}");
                    s += $"{j}*{k} = {j * k} \n";
                }
            }return s;
        }
    }
}