using System.Text;

Console.WriteLine($"В месяце {Month.March} {kolDay(Month.March)} дней");

static int kolDay(Month month) 
{
    if (month == Month.April || month == Month.June || month == Month.September || month == Month.November)
        return 30;
    else if (month == Month.February)
        return 28;
    else return 31;
}

enum Month 
{
    January,
    February,
    March,
    April,
    May,
    June,
    July,
    August,
    September,
    October,
    November,
    December
}