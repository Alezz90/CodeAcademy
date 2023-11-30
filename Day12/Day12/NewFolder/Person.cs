using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12.NewFolder
{
    public class Person
    {
        public int SSd;
        public string Name;
        public bool HasJoB;
        public Person() { }
        public Person(int SSd, string Name,bool HasJoB) { 
        this.SSd = SSd;
            this.Name = Name;
            this.HasJoB = HasJoB;
        }
        public void Des()
        {
            Console.WriteLine("**********************Person class*************************");
            Console.WriteLine($"{SSd} , {Name} , {HasJoB}");
        }
            
    }
}
