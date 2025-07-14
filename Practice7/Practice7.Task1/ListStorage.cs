using System;
using System.Collections.Generic;

namespace Practice7.Task1
{
  public class ListStorage<T> : IStorage<T>
  {
    List<T> list = new List<T>();
    public ListStorage() { }

    public void Add(T item)
    { 
      list.Add(item);
    }

    public T Get(int index)
    {
      if (index >= 0 && index < list.Count)
      {
        return list[index];
      }
      else
        throw new IndexOutOfRangeException("Индекс находится вне границ");

    }

    public int Count
    { 
      get { return list.Count; }
    }
  }
}
