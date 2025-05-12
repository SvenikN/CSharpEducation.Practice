class Program
{
    static void Main(string[] args)
    {
        int a = 3;
        int b = 9;
        Change(ref a, ref b);
        Console.WriteLine($"После вызова a = {a}, b = {b}");
    }

    static void Change(ref int a, ref int b)
    {
        int c = a;
        a = b;
        b = c;
        Console.WriteLine($"До вызова a = {a}, b = {b}");
    }
}