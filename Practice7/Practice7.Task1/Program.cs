using System;

namespace Practice7.Task1;
public class Program
{
  public static void Main(string[] args)
  {    
      ListStorage<string> stringStorage = new ListStorage<string>();

      stringStorage.Add("QQQQQ");
      stringStorage.Add("AAAAA");
      stringStorage.Add("BBBBB");

      Console.WriteLine($"Колмчество элементов = {stringStorage.Count}");

      Console.WriteLine($"Элемент 1 = {stringStorage.Get(0)}");
      Console.WriteLine($"Элемент 2 = {stringStorage.Get(1)}");
      Console.WriteLine($"Элемент 3 = {stringStorage.Get(2)}");

      ListStorage<int> intStorage = new ListStorage<int>();
      intStorage.Add(1);
      intStorage.Add(26);
      intStorage.Add(35);
      intStorage.Add(900);

      Console.WriteLine($"Количество элементов = {intStorage.Count}");

      Console.WriteLine($"Элемент 1 = {intStorage.Get(0)}");
      Console.WriteLine($"Элемент 2 = {intStorage.Get(1)}");
      Console.WriteLine($"Элемент 3 = {intStorage.Get(2)}");
      Console.WriteLine($"Элемент 4 = {intStorage.Get(3)}");

    try
    {
      Console.WriteLine($"Элемент по индексу 5: {stringStorage.Get(7)}");
    }
    catch (IndexOutOfRangeException ex)
    {
      Console.WriteLine($"Произошла ошибка: {ex.Message}");
    }
  }
}
