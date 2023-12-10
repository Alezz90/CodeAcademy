using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooAnimal
{
    internal class Bird : Animal
    {
        string ISflay;
        public Bird() { }
        public Bird(string name, string species, int age, DietType diet, string type) : base(name, species, age, diet)
        {
            ISflay = type;
        }
        public override void MakeSound()
        {
            Console.WriteLine("Bird makes a sound");
        }

        public void Fly()
        {
            Console.WriteLine("Bird flies");
        }
        public override void Display()
        {
            base.Display();
            Console.Write(ISflay);
        }
    }
}