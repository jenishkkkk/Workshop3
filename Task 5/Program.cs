using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        for (int i = 1; i <= N; i++)
        {
            sum += i;
        }
        Console.WriteLine("Sum = " + sum);

        int num = 1;
        while (num <= 20)
        {
            if (num == 15)
                break;

            if (num % 4 == 0)
            {
                num++;
                continue;
            }

            Console.WriteLine(num);
            num++;
        }

        int[] numbers = { 1, 2, 3, 4, 5 };
        int total = 0;

        foreach (int x in numbers)
        {
            total += x;
        }

        Console.WriteLine("Array Sum = " + total);
    }
}