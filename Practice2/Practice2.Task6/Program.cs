class Practice2
{
    static void Main(string[] args)
    {
        Part1();
        Part2();
    }

    static void Part1()
    {
        char simdol = 'a';
        int kol = 0;

        Console.WriteLine($"Введите строку ");
        string stroka = Console.ReadLine();

        foreach (char c in stroka)
        {
            if (c == simdol) kol++;
        }

        double percentage = (double)kol / stroka.Length * 100;
        Console.WriteLine($"Символ '{simdol}' встречается в строке {percentage:F2}%");
    }

    static void Part2()
    {
        int kol = 0;

        Console.WriteLine($"Введите строку ");
        string stroka = Console.ReadLine();

        Console.WriteLine($"Введите символ ");
        char simdol = Convert.ToChar(Console.ReadLine());

        foreach (char c in stroka)
        {
            if (c == simdol) kol++;
        }

        double percentage = (double)kol / stroka.Length * 100;
        Console.WriteLine($"Символ '{simdol}' встречается в строке {percentage:F2}%");
    }
}