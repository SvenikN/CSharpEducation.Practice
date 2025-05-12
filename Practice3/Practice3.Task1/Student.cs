using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3.Task1
{
    class Student
    {
        public string name;
        public int age;

        public Student(string name = "Name", int age = 18) 
        {
            this.name = name;
            this.age = age;
        }
        public void Print() => Console.WriteLine($"Имя студента {name} возраст {age}");
        
    }
}
