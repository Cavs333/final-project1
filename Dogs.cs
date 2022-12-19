/* Program Name: Example
Programmer: Logan Farlow
 Date: 12 / 19 / 2022
 Description: What does your program do? Be sure
  to keep everything within view on your screen. Edit
 this description to match what your program does. For
  example, "This program allows you to  Decribe your dog Name age an Breed and color
 users in a C# windows console application
*/

public class Dog


{
    // properties
    public string Breed { get; set; }
    public int Age { get; set; }
    public string Color { get; set; }

    // constructor
    public Dog(string breed, int age, string color)
    {
        Breed = breed;
        Age = age;
        Color = color;
    }

    // methods
    public void Bark()
    {
        Console.WriteLine("Woof! Woof!");
    }

    public void Fetch()
    {
        Console.WriteLine("Fetching the ball...");
    }
}
