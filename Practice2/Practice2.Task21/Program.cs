
Random r = new Random();
int randomNumber = r.Next(10);

while (true)
{
    Console.Write($"Введите число ");
    int number = Convert.ToInt16(Console.ReadLine());
   
    if (number == randomNumber)
    {
        Console.WriteLine($"Вы угадали число");
        break;
    }
}
