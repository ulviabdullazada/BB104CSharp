namespace Static.Models;
class Person
{
    public static int Count = 0;
    public readonly int Id;
    public string Name;
    public string Surname;

    //static constructor
    static Person()
    {
        Console.WriteLine("Static ctor worked");
    }
    //static Person(string name) olmaz
    //{
    //    Console.WriteLine("Static ctor worked");
    //}

    //non-static constructor
    public Person()
    {
        Console.WriteLine("Non-static ctor worked");
        Id = ++Count;
    }
    public void PrintInfo()
    {
        Console.WriteLine(Id + ". " + Name + " " + Surname);
    }
    public static void PrintPresidentName()
    {
        Console.WriteLine("Qurban oldugum");
    }
}
