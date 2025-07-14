using System;
using System.Collections.Generic;

namespace Practice7.Task3
{
  /// <summary>
  /// Сравнение по модели потом по марке, по возрастанию
  /// </summary>
  public class CarModelMakeComparer : IComparer<Car>
  {
    public int Compare(Car? carA, Car? carB)
    {
      if (carA is null || carB is null)
        throw new ArgumentException("Что-то не то");

      int makeComparison = string.Compare(carA.Model, carB.Model, StringComparison.OrdinalIgnoreCase);
      if (makeComparison != 0)
      {
        return makeComparison;
      }

      return string.Compare(carA.Make, carB.Make, StringComparison.OrdinalIgnoreCase);
    }
  }
}
