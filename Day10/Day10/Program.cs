namespace Day10
{
    internal class Program
    {
       public struct st
        {
           public int x;
            int y;
        }
        static void Main(string[] args)
        {
          

            Product product = new Product("Mouse",5);  
            Product product1 = new Product("Scree", 100);
            Product product3 = new Product("Laptop", 250);
            
            Product[] pro = { product, product1, product3 };  
            foreach (Product i in pro)
            {
                i.ProductPrint();
               
            }
            
        }
    }
}