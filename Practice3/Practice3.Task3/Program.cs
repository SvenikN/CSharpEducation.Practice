
using Practice3.Task3;

Console.Write($"Введите первое число - ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число - ");
double b = Convert.ToDouble(Console.ReadLine());

Calculator calculator = new();

Console.WriteLine();
Console.WriteLine($"Сумма {a} + {b} = {calculator.Sum(a, b)}");
Console.WriteLine($"Умножение {a} * {b} = {calculator.Multiply(a, b)}");
Console.WriteLine($"Деление {a} / {b} = {calculator.Divide(a, b)}");
Console.WriteLine($"Вычитание {a} - {b} = {calculator.Subtract(a, b)}");