namespace Inheritance.Models
{
    class Freshman : Student
    {
        public float Score;
        public Freshman() : base() //yazsaq da yazmasaq da
        {
            Console.WriteLine("Freshman created");
        }
        public Freshman(float score) : this()
        {
            
        }
    }
}
