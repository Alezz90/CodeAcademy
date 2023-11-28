namespace Day7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  int[] sumArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            
            int x = 1;
            int sum = AddNumbers(out x ,2,4,1);
            Console.WriteLine($"sum {sum} mult {x}");
        }

        static int AddNumbers(out int x ,params int[] numbers)
        {
            int sum = 0;
              x = 1;
            for (int i= 0; i < numbers.Length; i++ )
            {
                if (i > 2)
                {
                    x = numbers[i] * x;
                }
                 else 
                    sum += numbers[i];
            }
            return sum;
        }
    }
}