using System;
public class Program
{
    static void Main()
    {
        double katet_a = 3;
        double katet_b = 4;
        double hypotenuse = 5;

        double hypotenuse_x = Math.Sqrt(Math.Pow(katet_a, 2) + Math.Pow(katet_b, 2));
        Console.WriteLine($"Гипотенуза = {hypotenuse_x}");

        if (katet_a >= hypotenuse)
        {
            Console.WriteLine("Ошибка: Гипотенуза должна быть больше катета.");
        }
        else
        {
            double katet_x = Math.Sqrt(Math.Pow(hypotenuse, 2) - Math.Pow(katet_a, 2));
            Console.WriteLine($"Катет = {katet_x}");
        }
    }
}
