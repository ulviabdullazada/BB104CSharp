namespace Inheritance.Models
{
    class Person
    {
        public string Name;
        public string Surname;
        public byte Age;
        public Person(string name, string surname, byte age) : this(name, surname)
        {
            Age = age;
        }
        public Person(string name, string surname) : this(name)
        {
            if (surname.Length > 2)
            {
                Surname = surname;
            }
        }
        public Person(string name)
        {
            if (name.Length > 2)
            {
                Name = name;
            }
        }
        public void PrintInfo()
        {
            Console.WriteLine($"{this.Name} {Surname} {Age}");
        }
    }
}
