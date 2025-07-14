using System;
using System.Collections;
using System.Collections.Generic;

namespace Practice7.Task4
{
  public class MyDictionaryEnumerator : IEnumerator
  {
    private Dictionary<string, int> dictionary;
    private List<KeyValuePair<string, int>> list;
    private int position = -1;
    private bool isStarted = false;

    public MyDictionaryEnumerator(Dictionary<string, int> dictionary)
    {
      this.dictionary = dictionary;
      list = new List<KeyValuePair<string, int>>(dictionary);
    }

    public bool MoveNext()
    {
      isStarted = true;
      if (position < list.Count - 1)
      {
        position++;
        return true;
      }
      else return false;
    }

    public void Reset()
    {
      position = -1;
      isStarted = false;
    }

    public object Current
    {
      get
      {
        if (position == -1 || list.Count == 0 || !isStarted)
          throw new InvalidOperationException("Перечисление невозможно.");
        return list[position]; 
      }
    }
  }
}
