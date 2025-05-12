class Program
{
    static void Main(string[] args)
    {
        Part1(GetMessage());
        Part2(GetMessage());
        Part3(GetMessage());
        Part4(GetMessage());
    }
    static double GetMessage()
    {
        Console.WriteLine($"Введите число");
        double player = Convert.ToDouble(Console.ReadLine());
        return player;
    }
    static void Part1(double player)
    {
        double player2 = player / 1000.0;
        Console.WriteLine($"{player} метров = {player2} километров");
        Console.WriteLine();
    }
    static void Part2(double player)
    {
        double player2 = player * 100000;
        Console.WriteLine($"{player} километров = {player2} сантиметров");
        Console.WriteLine();
    }
    static void Part3(double player)
    {
        double player2 = player * 3.6;
        Console.WriteLine($"{player} м/с = {player2} км/ч");
        Console.WriteLine();
    }
    static void Part4(double player)
    {
        double player2 = (player * 9 / 5) + 32;
        Console.WriteLine($"{player} °C = {player2} °F");
        Console.WriteLine();
    }
}

