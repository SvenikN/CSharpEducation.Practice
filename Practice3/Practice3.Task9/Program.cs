
using Practice3.Task9;

Student student = new Student("Sveta", 18);
UpdateName(student);

Console.WriteLine(student.name);
Console.WriteLine(student.age);
void UpdateName(Student student)
{
    student.name = "Аноним";
}