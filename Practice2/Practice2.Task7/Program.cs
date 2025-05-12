class Program
{
    static void Main(string[] args)
    {
        Part1();
        Part2();
    }
    static void Part1()
    {
        Console.WriteLine($"Введите строку ");
        string stroka = Console.ReadLine();
        if (stroka != null) Console.WriteLine(stroka.ToUpper());
    }
    static void Part2()
    {
        Console.WriteLine($"Введите строку ");
        string stroka = Console.ReadLine();
        if (stroka != null) Console.WriteLine(stroka.ToLower());
    }
}