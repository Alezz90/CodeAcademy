using System;
using System.Xml.Linq;

namespace ZooAnimal
{
    internal class Program
    {
        static void Main(string[] args)
            
        {
            ZooEnclosures newAnimal = new ZooEnclosures();
          
            Bird bird = new Bird();
            Mammal mammal = new Mammal();
            Reptile rep = new Reptile();

            bool flage = true;
            while(flage) {
                Console.WriteLine($"Hello to zoo mngment system \n what you want to do \n 1. Add animal \n 2.display \n 3. Exit");
                int x;
                int.TryParse(Console.ReadLine(), out x);
                switch (x)
            {
                case 1:
                        Console.WriteLine($"type of animal \n 1.Bird \n 2.Mammal \n 3.Reptile ");
                        int animalTyp;
                        bool AnB= int.TryParse(Console.ReadLine(),out animalTyp);
                     
                    Console.WriteLine("name of animal");
                    string name = Console.ReadLine();
                    Console.WriteLine("name of species");
                    string species = Console.ReadLine();

                    Console.WriteLine("animal age");
                    int age;
                    bool agepars = int.TryParse(Console.ReadLine(), out age);
                        Console.WriteLine("DietType:\n 1.Carnivore, \r\n 2.Herbivore,  \n 3.Omnivore");
                        
                        DietType dit = (DietType)Enum.Parse(typeof(DietType), Console.ReadLine());

                        if (animalTyp == 1)
                        {
                            Console.WriteLine("ISflay");
                            string ISflay = Console.ReadLine();
                            bird = new Bird(name, species, age, dit, ISflay);
                           
                        }
                        else if (animalTyp == 2)
                        {
                            Console.WriteLine("Mamma Type");
                            string MammalType = Console.ReadLine();
                          mammal =new Mammal(name, species, age, dit, MammalType);
                        }
                        else if (animalTyp == 3)
                        {
                            Console.WriteLine("Reptile Type");
                            int.TryParse(Console.ReadLine(),out int numberofleg);
                           rep = new Reptile(name, species, age, dit, numberofleg);
                        }
                      
                    break;
                    case 2:
                        if (bird.ID != 0)
                        {
                            bird.Display();
                        }else if(mammal.ID != 0)
                        {
                            mammal.Display();
                        }
                        else if (rep.ID != 0)
                        {
                            rep.Display();
                        }


                        

                        break;
                    case 3:
                        newAnimal.ObserveAnimalActions();
                        Console.WriteLine("See you later");
                        flage = false;
                    break;
            }

            }

        }
    }
}