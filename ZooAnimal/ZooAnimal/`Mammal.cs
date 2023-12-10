using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooAnimal
{
    public class Mammal:Animal
    {
        string MammalType;

        public Mammal() { }
        public Mammal(string name, string species, int age, DietType diet, string type) : base(name, species, age, diet)
        {
            this.MammalType = type;
        }
        public override void MakeSound()
        {
            Console.WriteLine("Mammal makes a sound");
        }
        public override void Move()
        {
            Console.WriteLine("Mammul moves");
        }
        public override void Display()
        {
            base.Display();
            Console.Write(MammalType);
        }
    }
}
