using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15
{
    public class Report
    {
        public delegate bool filterEmp(Employee emp);
        public delegate bool MultiCasting(Employee emp,int x);
        public void MultiCastiDelgat(Employee[] emp, string title, MultiCasting DDe)
        {

        }
        public Employee[] TotalSaleseefilter(Employee[] emp, string title, filterEmp DDe)
        {
            int x = 0;
            Employee[] result = new Employee[x];
            
            Console.WriteLine($"*****************{title}**********************");
            foreach (Employee e in emp)
            {
                if (DDe(e))
                {
                    x += 1;
                    Console.WriteLine($" {e.Name} {e.TotalSale}");
                  
                    for(int i = 0; i < result.Length; i++)
                    {

                        result[i] = emp[i];
                    }
                   
                }
            }return result;
        }
            public void TotalSalesee3ok(Employee[] emp)
        {
            foreach (Employee e in emp)
            {
                if(e.TotalSale>=3)
                {
                    Console.WriteLine($" more than 3{e.Name} {e.TotalSale}");
                }
            }
            Console.WriteLine("***************************************");

        }


       public  void TotalSalesee2ok(Employee[] emp)
        {
            foreach (Employee e in emp)
            {
                if (e.TotalSale >= 2 && e.TotalSale <3)
                {
                    Console.WriteLine($"between 1-2 {e.IDEmp}: {e.Name} {e.TotalSale}");
                }
            }
            Console.WriteLine("***************************************");

        }

       public void TotalSalesee1ok(Employee[] emp)
        {
           
            foreach (Employee e in emp)
            {
                if (e.TotalSale >= 1 && e.TotalSale < 2)
                {
                    Console.WriteLine($"Less than1 {e.IDEmp}: {e.Name} {e.TotalSale}");
                }
            }
            Console.WriteLine("***************************************");
        }
    }
}
