using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
     class Coffee
    {
        static void Main()
        {
            String coffee ="";
            double coast = 0.0 ;
            String Size ="";
            String Suger ="";
            String Milk ="";

            Console.WriteLine("Welcome to the Coffee Shop!Menu:\n \t 1.Americano -$2.50 2.\n \t 2.Latte - $3.00 \n \t 3.Cappuccino - $3.50");
        //coffee Type 
           int coffeeType = Convert.ToInt32(Console.ReadLine());

            switch (coffeeType)
            {
               case 1:
                coffee = "Americano";
                    coast = 2.5;
                Console.WriteLine("Customizations:\r\n1.Small\r\n2.Medium\r\n3.Large\r\nSelect a size (1-3)");
                    break;
                case 2:
                coffee = "Late";
                    coast = 3.0;
                    Console.WriteLine("Customizations:\r\n1.Small\r\n2.Medium\r\n3.Large\r\nSelect a size (1-3)");
                    break;
                case 3:
                coffee = "Cappuccino";
                    coast = 3.5;
                Console.WriteLine("Customizations:\r\n1.Small\r\n2.Medium\r\n3.Large\r\nSelect a size (1-3)");
                    break;
                default:
                    Console.WriteLine("Please chosse from the menue?");
                    break;
            }
           // coffee size
            int CoffeeSize = Convert.ToInt32(Console.ReadLine());

          switch (CoffeeSize)
            {
                case 1:

                    Size = "Small";
                    Console.WriteLine("Do you want sugar? (yes/no)");
                   
                    break;
                case 2:
                    Console.WriteLine("Do you want sugar? (yes/no)");
                    Size = "Midiam";
                    break;
                case 3:
                    Console.WriteLine("Do you want sugar? (yes/no)");
                    Size = "Large";
                    break;
                default:
                    Console.WriteLine("Size plase?");
                    break;
            }
            //coffee Suger
            Suger = Console.ReadLine();

            if (Suger == "yes")
            {
                Suger = "with Suger";
               
            }
            else
                Suger = "with out Suger";
            Console.WriteLine("Do you want Milk?");
            // cofee Milk
           Milk = Console.ReadLine();

            if (Milk == "yes")
            {
                Milk = " and with Milk";
            }
            else
                Milk = " and with out Milk";
            Console.WriteLine("Your Order is \n " + coffee + "  " + Size + "  " + Suger + "" + Milk + "\n total coast is "+ coast +"\n \t Thank for ordering");



        }
    }
}
