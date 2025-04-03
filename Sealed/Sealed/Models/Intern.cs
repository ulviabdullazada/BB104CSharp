namespace Sealed.Models;
public class Intern : Worker
{
    public Intern(byte hours) : base(hours)
    {
        
    }
    public void GetSalary()
    {
        Console.WriteLine("200 maat");
    }
    public sealed override void Work()
    {
        Console.WriteLine("4 hours worked");
    }
}
