using System;

namespace Homework_05_Excercise07
{
    public class Dog
    {
        public string name, race, color;
        
        public void Eat()
        {
            Console.WriteLine($"The dog {name} is now eating");
        }

        public void Play()
        {
            Console.WriteLine($"The dog {name} is now playing");
        }

        public void ChaseTail()
        {
            Console.WriteLine($"The dog {name} is now chasing its tail.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Create a class Dog
            //Add properties: Name, race, color
            //The dog needs to have:
            //Eat method that returns message: The dog is now eating
            //Play method returning a message : The dog is now playing
            //ChaseTail method that returns a message: Dog is now chasing its tail.
            //The user needs to create the dog object by inputs and then given an option to choose one of the actions mentioned above.

            Console.WriteLine("Enter the dog name");
            var dogName = Console.ReadLine();
            Console.WriteLine("Enter the dog race");
            var dogRace = Console.ReadLine();
            Console.WriteLine("Enter the dog color");
            var dogColor = Console.ReadLine();
            Console.WriteLine("");
           
            Console.WriteLine("What is the dog doing, enter 1 for eating, 2 for playing or 3 for chasing it's tail");
            var dogBehavior = Console.ReadLine();
           
            var dog = new Dog();
            dog.name = dogName;
            dog.race = dogRace;
            dog.color = dogColor;

            switch (dogBehavior)
            {
                case "1":
                    dog.Eat();
                    break;
                case "2":
                    dog.Play();
                    break;
                case "3":
                    dog.ChaseTail();
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }

            Console.ReadLine();
        }
    }
}
