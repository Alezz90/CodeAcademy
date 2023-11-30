using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12.NewFolder
{
    public class Employee : Person
    {
        public string Department;
        public string JobTitle;
        public double WorkingHour;
        public double Swage;

        public Employee() { }
       public Employee(int SSd, string Name, bool HasJoB,string department,string jobTitle,double workingHour,double swage):base(SSd, Name, HasJoB)
        {

          Department=  department;
          JobTitle=  jobTitle;
          WorkingHour=  workingHour;
          Swage= swage;
        }
        
        public double CulcSalary()
        {
           // this.WorkingHour = WorkingHour;
            double swage = this.Swage;
            double Totalsalary = WorkingHour * swage;
            double salaryAfterswage = Totalsalary * .3;
            return Totalsalary-salaryAfterswage;
        }
        public void EmpPrint()
        {
            Console.WriteLine("**********************Employee class*************************");
           Console.WriteLine($"{SSd} , {Name} , {HasJoB}, {Department}, {JobTitle}, { WorkingHour}, {Swage}");
            Console.WriteLine(this.CulcSalary());
        }

    }
}
