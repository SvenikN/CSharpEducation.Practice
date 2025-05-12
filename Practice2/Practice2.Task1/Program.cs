class Practice2
{
    static void Main(string[] args)
    {
        Part1();
        Part2();
        Part3();
        Part4();
        Part5();
        Part6();
    }

    static void Part1()
    {

        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"{i} ");
        }

        Console.WriteLine();
    }

    static void Part2()
    {

        int j = 3;
        while (j <= 10)
        {
            Console.Write($"{j} ");
            j++;
        }

        Console.WriteLine();
    }

    static void Part3()
    {
        int a = 20;

        do
        {
            Console.Write($"{a} ");
            a--;
        }
        while (a >= 2);

        Console.WriteLine();
    }

    static void Part4()
    {

        string[] mas = new string[6];

        for (int i = 0; i <= 5; i++)
        {
            Console.Write($"Введите слово - ");
            string slovo = Console.ReadLine();
            mas[i] = slovo;
        }

        Console.Write($"Введена фраза ");
        for (int i = 0; i <= 5; i++)
        {
            Console.Write($"{mas[i]} ");
        }
    }

    static void Part5()
    {

        string[] mas = new string[4];
        int j = 0;

        while (j <= 3)
        {
            Console.Write($"Введите словечко - ");
            string slovo = Console.ReadLine();
            mas[j] = slovo;
            j++;
        }

        Console.Write($"Введена фраза ");

        for (int i = 0; i <= 3; i++)
        {
            Console.Write($"{mas[i]} ");
        }
    }

    static void Part6()
    {
        string[] mas = new string[3];

        int j = 0;
        do
        {
            Console.Write("Напиши слово ");
            string slovo = Console.ReadLine();
            mas[j] = slovo;
            j++;
        }
        while (j <= 2);

        Console.Write($"Введена фраза ");

        for (int i = 0; i <= 2; i++)
        {
            Console.Write($"{mas[i]} ");
        }
    }
}