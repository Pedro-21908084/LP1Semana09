using System;

namespace AnimInterf
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[10];
            Random randomNumber = new Random();

            //generate animals
            for(int i = 0;  i< animals.Length; i++)
            {
                int rnd = randomNumber.Next(0, 100);
                if(rnd > 75)
                    animals[i] = new Dog();
                else if (rnd > 50)
                    animals[i] = new Cat();
                else if (rnd > 25)
                    animals[i] = new Bat();
                else
                    animals[i] = new Bee();

            }

            for(int i = 0;  i< animals.Length; i++)
            {
                Console.WriteLine(animals[i].Sound());
                
                if(animals[i] is Dog)
                {
                    Dog dog = animals[i] as Dog;
                    Console.WriteLine($"The animal has " + 
                    $"{dog.NumberOfNipples} nipples.");
                }
                else if(animals[i] is Cat)
                {
                    Cat cat = animals[i] as Cat;

                    Console.WriteLine($"The animal has " + 
                    $"{cat.NumberOfNipples} nipples.");
                }
                else if(animals[i] is Bat)
                {
                    Bat bat = animals[i] as Bat;

                    Console.WriteLine($"The animal has " + 
                    $"{bat.NumberOfNipples} nipples.");

                    Console.WriteLine($"the animal flies with " + 
                    $"{bat.NumberOfWings} wings.");
                }
                else if(animals[i] is Bee)
                {
                    Bee bee = animals[i] as Bee;

                    Console.WriteLine($"the animal flies with " + 
                    $"{bee.NumberOfWings} wings.");
                }
            }

        }
    }
}
