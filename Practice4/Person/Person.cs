namespace Persons
{
    public class Person
    {
        public string name;
        public int age;

        public Person() : this("Не известно", 18) { }
        public Person(string name) : this(name, 18) { }
        public Person(string name, int age) 
        {
            this.name = name;
            this.age = age;
        }

        public void Print()
        {
            Console.WriteLine($"Имя {this.name} Возраст {this.age}");
        }
    }
}
