using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice7.Task4
{
  public class MyList : IEnumerable
  {
    int[] items = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

    public IEnumerator GetEnumerator() => items.GetEnumerator();
  }
}
