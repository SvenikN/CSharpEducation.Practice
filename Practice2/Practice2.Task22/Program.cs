
Random r = new Random();
int randomNumber = r.Next(100);
int kol = 1;

while (kol <= 10)
{
    Console.Write($"Введите число ");
    int number = Convert.ToInt16(Console.ReadLine());

    if (number == randomNumber)
    {
        Console.WriteLine($"Вы угадали число");
        Console.WriteLine($"Количество попыток = {kol}");
        break;
    }
    else if (number < randomNumber)
        Console.WriteLine($"Число больше");
    else Console.WriteLine($"Число меньше");

        kol++;
}
