
Console.WriteLine($"Введите переменную a");
double a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Введите переменную b");
double b = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Введите переменную f");
double f = Convert.ToDouble(Console.ReadLine());

if (( a == b ) ||  ( b == f ) || (a == f))
{
    a = a + 5;
    b = b + 5;
    f = f + 5;
    Console.WriteLine($"a = {a} b = {b} f = {f}");
}
else Console.WriteLine($"Равных нет");
