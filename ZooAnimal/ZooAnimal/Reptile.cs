using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooAnimal
{
    public class Reptile:Animal
    {
        int numberofleg;
        public Reptile() { }
        public Reptile(string name, string species, int age, DietType diet, int type) : base(name, species, age,diet)
        {
            numberofleg = type;
        }
        public override void MakeSound()
        {
            Console.WriteLine("Reptile makes a sound");
        }

        public void Swim()
        {
            Console.WriteLine("Reptile swims");
        }
        public override void Display()
        {
            base.Display();
            Console.Write(numberofleg);
        }
    }
}
