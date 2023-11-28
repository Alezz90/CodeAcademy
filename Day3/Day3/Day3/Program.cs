namespace Day3
{
     struct Program
    {
        static void Main()
        {
            

             //int x = Convert.ToInt32(Console.ReadLine()) ;
            //int y = x % 3;
            //string result = (y == 0) ? "yes it divisible" : "not disible";
            //Console.WriteLine(result);
            while (true)
            {

                Console.WriteLine("Welcome to the Simple Calculator!\r\nOptions:\r\n1. Addition\r\n2. Subtraction\r\n3. Multiplication\r\n4. Division\r\n5. Exit\r\nSelect an operation (1-5):");
                int oper = Convert.ToInt32(Console.ReadLine());

                if(oper >= 5) {
                    break;
                }
                Console.WriteLine("enter first operand ");
                int operand1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter Second operand ");
                int operand2 = Convert.ToInt32(Console.ReadLine());

                int[] operation = new int[4];
                operation[0] = operand1 + operand2;
                operation[1] = operand1 - operand2;
                operation[2] = operand1 * operand2;
                operation[3] = operand1 / operand2;
                string result = "";

                for (int i = 0; i <= operation.Length; i++)
                {
                    if (i == oper)
                    {
                        Console.WriteLine(operation[i - 1]);
                        Console.WriteLine("Do you have another operation");
                        result = Console.ReadLine();
                    }
                }

                if (result!= "yes")
                {
                    break;
                }
            }
        }
    }
}
