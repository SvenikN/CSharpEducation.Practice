using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3.Task2
{
    class Student
    {
        public string name;
        public int age;
        public int srBall;

        public Student(string name = "Name", int age = 0)
        {
            this.name = name;
            this.age = age;
        }

        public int SrBall
        {
            set {
                if (value <= 0 || value > 6)
                    Console.Write("Седний балл не адекватен - ");
                else
                    srBall = value;
            }
            get => srBall;
        }

        public string Name
        {
            get => this.name;
            set => this.name = value;
        }

        public int Age
        {
            get => this.age;
            set => this.age = value;
        }

        public void Print() => Console.WriteLine($" - Имя студента - {this.Name}, возраст - {this.Age}, средний балл - {this.SrBall}");
    }
}
