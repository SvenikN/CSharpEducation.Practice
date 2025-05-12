using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3.Task4
{
    internal class Book
    {
        private string _avtor;
        private string _nameBook;
        public Book() {
            _avtor = "Неизвестный автор";
            _nameBook = "Неизвечтное название";
        }
        public Book(string avtor, string nameBook)
        { 
            _avtor = avtor;
            _nameBook = nameBook;
        }

        public void Print() => Console.WriteLine($"автор книги - {_avtor}, название книги - {_nameBook}");
    }
}
