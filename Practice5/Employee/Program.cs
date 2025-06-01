using Employee;
using Logger;

namespace Employee;

class Program
{
    public static void Main(string[] args)
    {
        ILogger consoleLogger = new ConsoleLogger();

        using (FileLogger fileLogger = new FileLogger("log.txt"))
        {
            ILogger logger = fileLogger;

            Employee sv = new Employee("Sveta", 10050.9);
            Console.WriteLine($"Работник {sv.Name} возвращает от зарплаты {sv.CalculateBonus()}");

            consoleLogger.Info($"Подрядчик: {sv.Name}");
            fileLogger.Info($"Подрядчик: {sv.Name}");

            Manager al = new Manager("Aleksei", 150559.7, 7);
            Console.WriteLine($"Работник {al.Name} возвращает от зарплаты {al.CalculateBonus()}");

            Manager le = new Manager("Leonid", 444444, 3);
            Console.WriteLine($"Работник {le.Name} возвращает от зарплаты {le.CalculateBonus()}");

            Manager ga = new Manager("Gaga", 444444, 8);
            Console.WriteLine($"Работник {ga.Name} возвращает от зарплаты {ga.CalculateBonus()}");

            Contractor sa = new Contractor()
            {
                Name = "Sava",
                Salary = 0,
                HourlyRate = 10
            };
            Console.WriteLine($"Работник {sa.Name} имеет бонус = {sa.CalculateBonus(34)}");

            Employee ba = new Manager("Banan", 34234, 56);
            Console.WriteLine($"Работник {ba.Name} отдает {ba.CalculateBonus()}");

            Manager ma = (Manager)ba;
            ma.Name = "Manay";
            ma.Salary = 245.34;
            ma.TeamSize = 34;
            Console.WriteLine(ma.CalculateBonus());

            Employee vo = new Contractor("Vovan", 6543, 150);
            Console.WriteLine($"Работник {vo.Name} возвращает от зарплаты {vo.CalculateBonus()}");
        }
    }
}
