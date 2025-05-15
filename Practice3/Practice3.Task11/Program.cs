using Practice3.Task11;

Book b = new Book("Я познаю мир", "Автор");
string info = infoBook(b);
Console.WriteLine(info);

string infoBook(Book b)
{
    string info;
    info = b.title + ' ' + b.avtor;
    return info;
}