

int a = 1;
int b = 1;

bool validA = false;
bool validB = false;

while (!validA)
{
    Console.WriteLine("Введите первое число");
  try
  {
    a = Convert.ToInt32(Console.ReadLine());
    validA = true;
  }
  catch (FormatException)
  {
    Console.WriteLine("Некорректное значение");
  }
}

while (!validB)
{
    Console.WriteLine("Введите второе число");
try 
  {
    b = Convert.ToInt32(Console.ReadLine());
    validB = true;
  }
  catch (FormatException)
  {
    Console.WriteLine("Некорректное значение");
  }
}

  try 
  { 
    double rezult = a / b;
    Console.WriteLine($"Результат = {rezult}");
  }
  catch (DivideByZeroException)
  {
    Console.WriteLine("Исключение - DivideByZeroException");
    Console.WriteLine();
  }
  catch (Exception ex)
  {
    Console.WriteLine($"Исключение: {ex.Message}");
    Console.WriteLine();
  }
