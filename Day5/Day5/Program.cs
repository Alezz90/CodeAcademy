using System;

namespace Day5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string person = "15e";
            try
            {
                int Age= int.Parse(person);
                Console.WriteLine(Age.GetType() +" type of age" );
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }

            //            //implicit
            //            int x = 5;
            //            long y = x;
            //            // explicit
            //            double r = 2.4;
            //            int z = (int)r;
            //            Console.WriteLine($" y is {y} z is { z}");

            //            //Boxing toString(),Parse(),Convert
            //string St = "19e";
            //int numb = Convert.ToInt32(St);
            //Console.WriteLine(numb);
            //string CoStToIn = "25pc";
            //int x = int.Parse(CoStToIn);
            //Console.WriteLine(x);

            //            // using tryPars
            //           // bool TryBars;
            //            //int a;
            //            //string CodPars = "12e";
            //            //String TryBars = int.TryParse(CodPars, out a)? $"True{a} ":$"can not convert";
            //            //Console.WriteLine(TryBars);
            //Console.WriteLine( a.GetType());

        }
    }
}