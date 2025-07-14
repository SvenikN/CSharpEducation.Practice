using System;

namespace Practice7.Task3;

public class Program
{
  public static void Main()
  {
    var bookA = new Book("Ass", "Ggg");
    var bookB = new Book("Bss", "Fgg");
    var bookC = new Book("Acc", "Nmm");

    Book[] book = { bookA, bookB, bookC };

    Array.Sort(book);

    foreach (Book bo in book)
      Console.WriteLine(bo.Title);

    var carA = new Car("Volvo", "Caca");
    var CarB = new Car("BMW", "ABC");
    var CarC = new Car("BMW", "Abb");
    var CarD = new Car("Mersedes", "Caca");

    Car[] cars = { carA, CarB, CarC, CarD};

    Console.WriteLine("Сортировка по марке потом по модели");
    Array.Sort(cars, new CarMakeModelComparer());

    foreach (Car c in cars)
      Console.WriteLine($"{c.Make} - {c.Model}");

    Console.WriteLine("Сортировка по модели потом по марке");
    Array.Sort (cars, new CarModelMakeComparer());

    foreach (Car c in cars)
      Console.WriteLine($"{c.Model} - {c.Make}");
  }
}