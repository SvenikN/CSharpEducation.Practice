using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice7.Task3
{
  public class Book : IComparable<Book>
  {
    public string Title { get; set; }

    public string Author { get; set; }

    public Book(string title, string author)
    {
      Title = title;
      Author = author;
    }

    public int CompareTo(Book? book)
    {
      if (book is null)
        throw new ArgumentException("Что-то не то");
      return Title.CompareTo(book.Title);
    }
  }
}
