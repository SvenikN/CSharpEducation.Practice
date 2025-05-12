
int[,] mas = new int[4,5];
Random r = new Random();
int max=0;
int min = 100;

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 5; j++)
    {
        mas[i,j] = r.Next(1, 100);
        Console.Write(mas[i,j] + " ");
    }
    Console.WriteLine();
}

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 5; j++)
    { 
        if (max < mas[i,j])
            max = mas[i,j];
        if (min > mas[i,j])
            min = mas[i,j];
    }
    Console.WriteLine($"Максимальное число в {i} строке = {max}");
    Console.WriteLine($"Минимальное число в {i} строке = {min}");
    Console.WriteLine($"Разница =  {max - min}");
    max = 1;
    min = 100;
}
