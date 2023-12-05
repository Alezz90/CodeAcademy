using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13
{
    public class Human
    {

    }
    public class Person :Human, IFeature
    {
        string name;
        int SSd;

        public Person() { }
        public Person(string name, int SSd)
        {
            this.name = name;
            this.SSd = SSd;
        }

        public override string ToString()
        {
            return $" welcome {name}, your SSD {SSd}";
        }
        public virtual void Display()
        {
            Console.WriteLine("Virtual method");
        }
        public void eate()
        {
            Console.WriteLine("eat");
        }
        public void walk()
        {
            Console.WriteLine("walk");
        }
    }
}
