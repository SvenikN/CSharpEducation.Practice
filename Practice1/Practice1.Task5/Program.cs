using System;
public class Program
{
    static void Main()
    {
        Console.Write("Введите фразу: ");
        string partOne = Console.ReadLine();
        Console.Write("Продолжите мысль: ");
        string partTwo = Console.ReadLine();

        Console.WriteLine($"{partOne} {partTwo}");
    }
}