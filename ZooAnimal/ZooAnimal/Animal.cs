using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooAnimal
{
    public enum DietType {
         Carnivore=1, 
        Herbivore,  
       Omnivore
    }
    public class Animal
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }

        public DietType DietType;
        public Animal() { }
        public Animal( string name, string species, int age,DietType diet)
        {
            ID += 1;
            Name = name;
            Species = species;
            Age = age;
            DietType = diet;
        }
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }

        public virtual void Move()
        {
            Console.WriteLine("Animal moves");
        }
        public virtual void Display()
        {

            Console.Write($"{Name} {Age} {Species} {DietType}"); 
        }

    }
}
