using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        if (age < 12)
        {
            Console.WriteLine("Child");
        }
        else if (age >= 12 && age < 18)
        {
            Console.WriteLine("Teenager");
        }
        else if (age >= 18 && age < 60)
        {
            Console.WriteLine("Adult");
        }
        else
        {
            Console.WriteLine("Senior Citizen");
        }
    }
}