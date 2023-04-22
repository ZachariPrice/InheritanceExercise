using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var myBird = new Bird();
            myBird.wings = 2;
            myBird.HasFeathers = true;
            myBird.HasABeak = true;
            myBird.Type = "Pokemon";

            var lizard = new Reptiles()
            {
                IsColdBlooded = true,
                HasScales = true,
                Habitat = "Volcano Cave",
                CanGrowTail = true,
            };

            var myAnimals = new Animal[] { myBird, lizard };

            foreach(var animal in myAnimals) 
            {
                Console.WriteLine($"Alive:{animal.isAlive}");
                Console.WriteLine($"Age:{animal.Age} years old");
                Console.WriteLine($"It has {animal.Legs} legs");
                Console.WriteLine($"Its name is {animal.Name}");
            }


          


            
            
            
            //Animal animal = new Animal();
            //animal.HasBrain = true;
            //animal.Legs = 0;


            //Dog dog = new Dog();

            //dog.CanBark = true;
            //dog.GaurdsHouse = true;
            //dog.HasPuppies = true;
            //dog.HasBrain = true;
            //dog.Legs = 4;

            //Reptiles husky = new Reptiles();

            //husky.CurledTail = true;
            //husky.HighIntelligence = false;
            //husky.CanBark = true;
            //husky.GaurdsHouse = true;
            //husky.Legs = 4;
            //husky.HasMouth = true;

            //Animal[] array = new Animal[3];

            //array[0] = animal;
            //array[1] = dog;
            //array[2] = husky;

            //dog.PrintDogDetails();


            //foreach (var item in array)
            //{
            //    Console.WriteLine(item.GetType());
            //    Console.WriteLine($"Has brain: (item.HasBrain)");
            
            // TODO Be sure to follow
            // best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
