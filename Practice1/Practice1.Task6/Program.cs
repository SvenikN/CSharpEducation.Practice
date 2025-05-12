using System;
public class Program
{
    static void Main()
    {
        const double Pi = 3.14;
        var radius = 7;

        double S = Pi * Math.Pow(radius, 2);

        Console.WriteLine($"Площадь круга с радиусом { radius} равна { Math.Round(S, 2)}");
    }
}
