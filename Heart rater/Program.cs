using Heart_rater;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your age:");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter patient information:");
        Console.WriteLine("First Name:");
        string firstName = Console.ReadLine();

        Console.WriteLine("Last Name:");
        string lastName = Console.ReadLine();

        Console.WriteLine("Weight (in kg):");
        double weight = double.Parse(Console.ReadLine());

        Console.WriteLine("Height (in cm):");
        double height = double.Parse(Console.ReadLine());

        Patient patient = new Patient(firstName, lastName, weight, height);

        Console.WriteLine("Patient Information:");
    }
}

