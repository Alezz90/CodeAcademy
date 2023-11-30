using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    class Product 
    {
        public static int Id;
        public int ProductNum;
        public string ProductName;
        public double price;

        public Product()
        {
             
        }
        public Product(string name,double val)  
        {
            Id +=1;
            ProductNum = Id;
            ProductName = name;
            price = ProductTax(val);
        }
        public void ProductPrint() 
        {
            Console.WriteLine($" id: {ProductNum}\n Product Name :{ProductName} \n price: {price}");
            Console.WriteLine("______________________________________________________________");
        }
        public double ProductTax(double val) 
        {
            double price = val * .10;
            return val-price;
        }
    }
}
