using Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Contractor : Employee
    {
        private readonly ILogger _logger;
        public Contractor(ILogger logger)
        {
            _logger = logger;
        }
        public int HourlyRate { get; set; }

        public Contractor() { }
        public Contractor(string name, double salary, int hourlyRate)
            : base(name, salary)
        {
            HourlyRate = hourlyRate;
        }
        public new double CalculateBonus()
        {
            _logger.Warning("CalculateBonus() без параметров для Contractor не поддерживается");
            return 0;
        }

        public double CalculateBonus(int hoursWorked)
        {
            double salary = HourlyRate * hoursWorked;
            _logger.Info($"Вычислено: {salary} за {hoursWorked} часов работы.");
            return salary;
        }
    }
}
