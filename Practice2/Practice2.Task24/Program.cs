
using System;
class Program
{
    enum DayWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    static void Main(string[] args)

    {
        PrintMessage(DayWeek.Monday);
        PrintMessage(DayWeek.Thursday);
        PrintMessage(DayWeek.Sunday);
        PrintMessage(DayWeek.Saturday);
        PrintMessage(DayWeek.Friday);
        PrintMessage(DayWeek.Wednesday);
        PrintMessage(DayWeek.Tuesday);
    }

    static void PrintMessage(DayWeek day)
    {
        switch (day)
        {
            case DayWeek.Monday:
                Console.WriteLine($"Понедельник");
                break;
            case DayWeek.Tuesday:
                Console.WriteLine($"Вторник");
                break;
            case DayWeek.Wednesday:
                Console.WriteLine($"Среда");
                break;
            case DayWeek.Thursday:
                Console.WriteLine($"Четверг");
                break;
            case DayWeek.Friday:
                Console.WriteLine($"Пятница");
                break;
            case DayWeek.Saturday:
                Console.WriteLine($"Суббота");
                break;
            case DayWeek.Sunday:
                Console.WriteLine($"Воскресенье");
                break;
        }
    }    
}
