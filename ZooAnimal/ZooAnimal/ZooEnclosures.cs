using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ZooAnimal
{
    public class ZooEnclosures : Animal
    {
        Mammal mammal;
        static List<Reptile> rept = new List<Reptile>();
        static List<Bird> bird = new List<Bird>();

        public void ObserveAnimalActions()
        {
            if (mammal != null)
                
                    mammal.Move();
                    mammal.MakeSound();
                    Console.WriteLine();
                
            foreach (Bird m in bird) if (bird != null)
                {
                    m.Move();
                    Console.WriteLine();
                }

        }
    }
}