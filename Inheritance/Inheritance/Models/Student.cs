//CTRL+R yuxaridaki usingleri silir
namespace Inheritance.Models
{
    class Student : Person
    {
        public string University;
        public byte Course;

        public Student() : base("Aytan", "Ibadova")
        {
            Console.WriteLine("Student created");
        }
        public void Fail()
        {
            Console.WriteLine("Elemiyun!");
        }
    }
}
