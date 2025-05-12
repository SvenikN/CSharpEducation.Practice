class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Введите переменную a");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Введите переменную b");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Введите переменную f");
        double f = Convert.ToDouble(Console.ReadLine());

        if (a != 0)
        {
            double Result = (a + b - f / a) + f * a * a - (a + b);
            Console.WriteLine($"Результат = {Result}");
        }
        else 
            Console.WriteLine($"Нельзя делить на 0");
    }
}