using System;

namespace Practice7.Task2
{
  public class Person : ICloneable
  {
    public string Name { get; set; }
    public int Age { get; set; }
    public Company Work { get; set; }

    public Person(string name, int age, Company company)
    {
      Name = name;
      Age = age;
      Work = company;
    }

    public object Clone() => new Person(Name, Age, new Company(Work.Name));
  }
}
