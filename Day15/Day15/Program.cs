using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using static Day15.Report;

namespace Day15
{
     class Program
    {
        public static void print<T>(T emp)
        {
            Console.WriteLine(typeof(T));
            Console.WriteLine(emp);
        }
        static void Main(string[] args)
        {

            //generic
            print(3);
            print("pri");
            print(3.3m);

            //Dleget

            Employee [] employee = new Employee[] {
               new Employee{Name="name1",Gender="f",TotalSale=2.5},
               new Employee {Name = "name2",Gender="f",TotalSale = 3.5},
               new Employee{Name="name3",Gender="M",TotalSale=3},
               new Employee{Name="name4",Gender="f",TotalSale=2},
               new Employee{Name="name5",Gender="M",TotalSale=1}
          };
             Report report = new Report();
            report.TotalSalesee(employee, (emp) => emp.TotalSale >= 3);
            /* report.TotalSalesee3ok(employee);
             report.TotalSalesee2ok(employee);
             report.TotalSalesee1ok(employee);*/
         
            report.TotalSaleseefilter(employee, $"More than 3 ", (emp) => emp.TotalSale >= 3);
            report.TotalSaleseefilter(employee, $"More than 2 ", (emp) => emp.TotalSale >= 2 && emp.TotalSale < 3);
            report.TotalSaleseefilter(employee, $"More than 1 ", (emp) => (emp.TotalSale >= 1 && emp.TotalSale < 2));
            report.TotalSaleseefilter(employee,$"filering female ",(emp) => (emp.Gender=="f"));
            report.TotalSaleseefilter(employee,$"filtering Male ",(emp)=>emp.Gender=="M");

           // List<Employee> result = report.TotalSaleseefilter(employee, $"filering female ", (emp) => (emp.Gender == "f"));
            int resultle = report.TotalSaleseefilter(employee, $"filering female ", (emp) => (emp.Gender == "f")).Length;
            report.TotalSalesee(employee, (emp) => emp.TotalSale >= 3);
            Console.WriteLine(resultle);
           

            //  int x = report.TotalSaleseefilter(employee, $"filtering Male ", (emp) => emp.Gender == "M");
            // Console.WriteLine(x);

            


        }
       
    }
}