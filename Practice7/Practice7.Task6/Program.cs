using System;

namespace Practice7.Task6;

public class Program
{
  public static void Main(string[] args)
  {
    string str1 = "А роза упала на лапу Азора";
    string str2 = "Hello";
    string str3 = "";
    string str4 = null;

    Console.WriteLine($"\"{str1}\" is palindrome: {str1.IsPalindrome()}");
    Console.WriteLine($"\"{str2}\" is palindrome: {str2.IsPalindrome()}");
    Console.WriteLine($"\"{str3}\" is palindrome: {str3.IsPalindrome()}");
    Console.WriteLine($"null is palindrome: {str4.IsPalindrome()}");

    Console.WriteLine($"{str1.ToTitleCase()}");
    Console.WriteLine($"{str2.ToTitleCase()}");
  }
}