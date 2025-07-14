using System;
using System.Collections;
using System.Collections.Generic;

namespace Practice7.Task4
{
  public class MyDictionary : IEnumerable
  {
    public Dictionary<string, int> items = new Dictionary<string, int>();
    
    public IEnumerator GetEnumerator() => new MyDictionaryEnumerator(items);
  }
}
