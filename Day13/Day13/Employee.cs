using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13
{
    public class Employee :Person
    {
        public string role;
        public string JobTitle;
        public double WorkingHour;
        public double Swage;

        public Employee() { }
        public Employee(string name, int ssd, string role, string jobTitle, double workingHour, double swage) : base(name, ssd)
        {
            this.role = role;
            this.JobTitle = jobTitle;
            this.WorkingHour = workingHour;
            this.Swage = swage;
        }
        //working with override key word
        public override string ToString()
        {
            return base.ToString() + $" your role is {role}";
        }
        public override sealed void Display()
        {
            Console.WriteLine("Sealed method");
        }
    }


    class ITEmp
    {
        int id;
        ITEmp()
        {

        }
      /* public override void Display()
        {

        }*/
    }
}
