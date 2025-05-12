using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3.Task5
{
    internal class Book
    {
        private string _avtor;
        private string _nameBook;
        private int _yearPublic;

        public Book() : this("Неизвестное название", "Неизвестный автор", 0) { }
        public Book(string nameBook) : this(nameBook, "Неизвестный автор", 0) { }
        public Book(string nameBook, string avtor) : this(nameBook, avtor, 0) { }
        public Book(string nameBook, string avtor, int yearPublic)
        {
            this._avtor = avtor;
            this._nameBook = nameBook;
            this._yearPublic = yearPublic;
        }

        public string Avtor
        {
            get => _avtor; 
            set => _avtor = value;
        }

        public string NameBook
        {
            get => _nameBook;
            set => _nameBook = value;
        }

        public int YearPublic
        { 
            get => _yearPublic;
            set => _yearPublic = value;
        }
        public void Print() => Console.WriteLine($"автор книги - {Avtor}, название книги - {NameBook}, год выпуска {YearPublic}");
    }
}
