
using System;
class Program
{
    enum DayWeek
    {
        Monday=1,
        Tuesday=2,
        Wednesday=3,
        Thursday=4,
        Friday=5,
        Saturday=6,
        Sunday=7
    }
    static void Main(string[] args)

    {
        Console.WriteLine($"Введите число от 1 до 7");
        int day = Convert.ToInt16(Console.ReadLine());
        

        switch (day)
        {
            case 1:
                Console.WriteLine($"Понедельник");
                break;
            case 2:
                Console.WriteLine($"Вторник");
                break;
            case 3:
                Console.WriteLine($"Среда");
                break;
            case 4:
                Console.WriteLine($"Четверг");
                break;
            case 5:
                Console.WriteLine($"Пятница");
                break;
            case 6:
                Console.WriteLine($"Суббота");
                break;
            case 7:
                Console.WriteLine($"Воскресенье");
                break;
        }
    }
}
