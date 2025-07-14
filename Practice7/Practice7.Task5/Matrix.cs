using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice7.Task5
{
  public class Matrix
  {
    public int[,] matrix = new int[,] { { 1, 2, 4 }, { 2, 3, 6 }, { 3, 4, 8 } };

    public int this[int i, int j]
    {
      get
      {
        if (i >= 0 && i < matrix.GetLength(0) && j >= 0 &&  j < matrix.GetLength(1) )
          return matrix[i, j];
        else
          throw new IndexOutOfRangeException("Индекс находится вне границ матрицы.");
      }
      set
      {
        if (i >= 0 && i < matrix.GetLength(0) && j >= 0 && j < matrix.GetLength(1))
          matrix[i, j] = value;
        else
          throw new IndexOutOfRangeException("Индекс находится вне границ матрицы.");
      }
      }
  }
}
