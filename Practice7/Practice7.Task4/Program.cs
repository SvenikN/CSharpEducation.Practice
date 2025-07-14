using System;
using System.Collections.Generic;
using System.Globalization;

namespace Practice7.Task4;

public class Program
{
  public static void Main(string[] args)
  {
    MyList myList = new MyList();

    foreach (var item in myList)
    {
      Console.WriteLine(item);
    }

    MyDictionary myDictionary = new MyDictionary();
    myDictionary.items.Add("One", 1);
    myDictionary.items.Add("Two", 2);
    myDictionary.items.Add("Three", 3);

    foreach (KeyValuePair<string, int> item in myDictionary)
    {
      Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
    }

 
    foreach (int n in Numbers.GetEvenNumbers(5,15))
      Console.WriteLine(n);
  }
}
