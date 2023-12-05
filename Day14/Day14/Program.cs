using System;

namespace Day14
{
    [Flags]
    enum Permissions
    {
        None = 0, //    0b_0000_0000 ->0
        Read = 1, //    0b_0000_0001 ->1
        Write = 2,//    0b_0000_0010-->2
        Delete = 4,//   0b_0000_0100-->4
        Execute = 8, //  0b_0000_1000-->8
        Level1 = Read | Write,
        Admin = Read | Write | Delete,
        superAdmin = Read | Write | Delete | Execute,
    }
    enum Monthes
    {
        Jun = 1,
        Feb,
        March,
        April,
        May,
        Jun6,
        Julay,
        August,
        Sept,
        Acto,
        Nov,
        Dece,
    }
    internal class Program
    {
        static void Main(string[] args)
        {

         /*   Permissions mypermissions = Permissions.Read | Permissions.Write;
            Console.WriteLine(mypermissions); // outputs: read, write

            Permissions User = Permissions.Read | Permissions.Write;
            if (User.HasFlag(Permissions.Level1))
            {
                Console.WriteLine($"you have only read write your CARDENTIALS IS :" +
                    $" {Permissions.Level1.ToString()} ");
            }

            Monthes monthes = Monthes.Julay;
            Console.WriteLine($"{monthes} {(int)monthes}");

            string month = "Julay";
            
             Console.WriteLine((int)(Enum.Parse(typeof(Monthes), month)));

            foreach (Monthes m in Enum.GetValues(typeof(Monthes)))
            {
                Console.WriteLine(m + ":" + (int)m);
            }

            string month7 = "Jue";
           
            if (Enum.IsDefined(typeof(Monthes), month7))
            {
                Console.WriteLine(Enum.Parse(typeof(Monthes), month7));

            }else
                Console.WriteLine("Monthe is not found");*/

            OverUser Usr1 = new OverUser(2);
            OverUser User2 = new OverUser(6);

            Console.WriteLine($" operator + {User2+Usr1}");

            Console.WriteLine($" operator == {User2 == Usr1}");

        }
    }
}