namespace Delegate.Models;
internal class Student
{
    static int _count = 0;
    public int Id { get; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public Student(string name, string surname, int age)
    {
        Id = ++_count;
        Name = name;
        Surname = surname;
        Age = age;
    }
    public override string ToString()
    {
        return $"{Id}. {Surname} {Name} {Age}";
    }
}
