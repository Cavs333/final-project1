using System;
using System.Collections.Generic;

namespace DogExample
{
    // This is the Dog class. It has two properties: Name and Breed.
    class Dog
    {
        public string Name { get; set; }
        public string Breed { get; set; }

        // This is the constructor for the Dog class. It takes two arguments:
        // the name and breed of the dog.
        public Dog(string name, string breed)
        {
            Name = name;
            Breed = breed;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a new List of Dogs.
            List<Dog> dogs = new List<Dog>();

            // Add some dogs to the list.
            dogs.Add(new Dog("Buddy", "Golden Retriever"));
            dogs.Add(new Dog("Daisy", "Beagle"));
            dogs.Add(new Dog("Max", "German Shepherd"));

            // Loop through the list of dogs and print their names and breeds.
            foreach (Dog dog in dogs)
            {
                Console.WriteLine($"{dog.Name} is a {dog.Breed}.");
            }
        }
    }
}
