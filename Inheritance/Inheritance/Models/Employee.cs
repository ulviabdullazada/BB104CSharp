namespace Inheritance.Models
{
    class Employee : Person //inheritance
    {
        //Person inheritance alan classdir.
        //Employee ise derived classdir.

        ////field
        //public string Name;
        //public string Surname;
        //public byte Age;
        public float Salary;
        public byte Experience;

        public Employee() : base("Gumush", "Jumayeva")
        {
            
        }
        public Employee(string name, string surname, byte age) : base("Murad", surname, age)
        {

        }
        //method
        public void Isleeee()
        {
            Console.WriteLine("Davayyy! Kole");
        }
    }
}
