
        Console.WriteLine($"Введите первое число");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Введите второе число");
        int y = Convert.ToInt32(Console.ReadLine());

        if (x > y) Console.WriteLine($"Число {x} больше {y}");
        else if (x < y) Console.WriteLine($"Число {x} меньше {y}");
        else Console.WriteLine($"Числа {x} и {y} равны"); 