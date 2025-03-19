using Encapsulation.Models;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person aytan = new()
            //{
            //    Name = "Aytan",
            //    Surname = "Ibadova"
            //};
            //Person roya = new()
            //{
            //    Name = "Roya",
            //    Surname = "Huseynova"
            //};
            //Console.WriteLine(aytan.GetInfo());

            //Child c = new Child();
            //char c = Console.ReadKey().KeyChar;
            //if (Char.IsLower(c))
            //{
            //    Console.WriteLine("Kicik herfdir");
            //}
            //else
            //{
            //    Console.WriteLine("kicik herf deyildir");
            //}

            User user = new("ulviii")
            {
                Age = 22
            };
            user.SetUsername("asd");
            user.SetUsername("U123");
            user.Password = "12sfsdf23";
            Console.WriteLine(user.Password);
            //Console.WriteLine(user.GetUsername());
        }
    }
}
