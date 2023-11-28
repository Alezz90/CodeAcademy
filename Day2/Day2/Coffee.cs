using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
     class Coffee
    {
        static string Yes_No(string QY_N)
        {
            bool ValidInput = false;
            string valid = QY_N;
            do
            {
                Console.WriteLine("Yes or no please ?");
                valid = Console.ReadLine().ToLower();
                ValidInput = (valid == "yes")|| (valid == "no");
            } while (ValidInput == false);
           return valid;
        }
        static void Display_Menu(int coffeeType, out string coffee,out double coast )
        {
            coast = 0.0;
            coffee = "";
            switch (coffeeType)
            {
                case 1:
                    coffee = "Americano";
                    coast = 2.5;
                    
                    break;
                case 2:
                    coffee = "Late";
                    coast = 3.0;
                   // Console.WriteLine("Customizations:\r\n1.Small\r\n2.Medium\r\n3.Large\r\nSelect a size (1-3)");
                    break;
                case 3:
                    coffee = "Cappuccino";
                    coast = 3.5;
                   // Console.WriteLine("Customizations:\r\n1.Small\r\n2.Medium\r\n3.Large\r\nSelect a size (1-3)");
                    break;
                default:
                    Console.WriteLine("Please chosse from the menue?");
                    break;
            }
           
        }

        static double Customization(double coast, out String Size)
        {
            
            double price = coast;
             Size = "";
          
            Console.WriteLine("Customizations:\r\n1.Small\r\n2.Medium\r\n3.Large\r\nSelect a size (1-3)");
            int CoffeeSize;
            bool ValidSize = false;
            do
            {
                Console.WriteLine("please choose the number from the menu?");
                ValidSize = int.TryParse(Console.ReadLine(), out CoffeeSize) && (CoffeeSize < 4) && (CoffeeSize > 0);
            }

            while (ValidSize == false);

            switch (CoffeeSize)
            {
                case 1:
                    Size = "Small";
                   
                  //  Console.WriteLine("Do you want sugar? (yes/no)");

                    break;
                case 2:
                    Size = "Midiam";
                    price += .5;
                   // Console.WriteLine("Do you want sugar? (yes/no)");
                    
                    break;
                case 3:
                  
                    Size = "Large";
                    price += 1;
                    break;
                default:
                    Console.WriteLine("Size plase?");
                    break;
            }
        
            return price;

        } 
       static string display_order_summary(double coast, string Milk, string Suger, string Size, string coffee)
        {
           string summary = $"Your Order is \n  {coffee} { Size} { Suger }  { Milk} \n total coast is {coast }\n \t Thank for ordering";
            return summary;
        }
        static void Main()
        {
            String coffee ="";
            double coast = 0.0 ;
            String Size = "";
            String Suger = "";
            String Milk = "";
            int coffeeType;
            Console.WriteLine("Welcome to the Coffee Shop!Menu:\n \t 1.Americano -$2.50 \n \t 2.Latte - $3.00 \n \t 3.Cappuccino - $3.50");
            bool ValidNumber = false;
            do
            {
               Console.WriteLine("please choose the number from the menu?");
               ValidNumber = int.TryParse(Console.ReadLine(), out coffeeType) && (coffeeType < 4) && (coffeeType > 0);
            }
            while (ValidNumber == false);
           
            Display_Menu(coffeeType, out coffee, out coast);
            Customization(coast, out Size);
            Console.WriteLine("Do you want sugar? (yes/no)");
            string QY_N = Console.ReadLine().ToLower();
            if (Yes_No(QY_N) == "yes")
            {
                Suger = "with Suger";
            }
            else
                Suger = "with out Suger";
            Console.WriteLine("Do you want Milk?");
            if (Yes_No(QY_N) == "yes")
            {
                Milk = " and with Milk";
            }
            else
                Milk = " and with out Milk";
            Console.WriteLine(display_order_summary(coast, Milk, Suger, Size, coffee));



        }
    }
}
