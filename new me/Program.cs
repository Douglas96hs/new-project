using System;
using System.Reflection.PortableExecutable;

internal class Program
{
    public Program()
    {
    }

    private static void Main(string[] args)
    {
        byte number = 2;
        int count = 10;
        float totalPrice = 20.95f;
        char character = 'A';
        string firstName = "Douglas";
        bool isWorking = false;

        Console.WriteLine(number);
        Console.WriteLine(count);
        Console.WriteLine(totalPrice);
        Console.WriteLine(Character);
        Console.WriteLine(firstName);
        Console.WriteLine(isWorking);
    }
}