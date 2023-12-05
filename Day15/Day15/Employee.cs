using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15
{
    public class Employee
    {
        public static int ID ;
        public int IDEmp { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

        public double TotalSale { get; set; }

        public Employee()
        { }
           public Employee(string Name,string Gender,double Total) {
            ID += 1;
            IDEmp = ID;
            this.Name = Name;
            this.Gender = Gender;
            this.TotalSale = Total;
        }
       
    }
}
