using System;

namespace Practice7.Task2;

public class Program
{
  public static void Main()
  {
    var tom = new Person("Tom", 45, new Company("SSSS"));
    var bob = (Person)tom.Clone();
    bob.Name = "Test";

    var ded = (Person)tom.Clone();
    ded.Name = "Dadly";
    ded.Age = 23;
    ded.Work.Name = "GGGG";
  
    Console.WriteLine($"{tom.Name}, {tom.Age}, {tom.Work.Name}");
    Console.WriteLine($"{bob.Name}, {bob.Age}, {bob.Work.Name}");
    Console.WriteLine($"{ded.Name}, {ded.Age}, {ded.Work.Name}");
  

  }
}