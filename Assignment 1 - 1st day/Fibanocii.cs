using System;

class Program
{
    static int Fibonacci(int number)
    {
        if (number <= 1)
            return number;
        return Fibonacci(number - 1) + Fibonacci(number - 2);
    }

    static void Main()
    {
        Console.Write("Enter Number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine($"Fibonacci({number}) = {Fibonacci(number)}");
    }
}