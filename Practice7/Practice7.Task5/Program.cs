using System;

namespace Practice7.Task5;

public class Program
{
  public static void Main()
  {try 
    {
    Matrix matrix = new Matrix();
    Console.WriteLine(matrix[1 , 1]);

    matrix[1, 1] = 56;
    Console.WriteLine(matrix[1 , 1]);

    Console.WriteLine(matrix[6, 1]);
    }
    catch (IndexOutOfRangeException ex)
    {
      Console.WriteLine(ex.Message);
    }
  }
}
