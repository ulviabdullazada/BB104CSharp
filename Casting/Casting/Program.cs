using System.Reflection;

namespace Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Penguin leyla = new Penguin();
            //Owl gulyana = new Owl();
            //Parrot nuruw = new Parrot();
            //Shark gulmaya = new Shark();
            ////Upcasting - bir tipin miras aldigi tip olaraq yanashilmasi
            //Animal[] bizimkiler = [leyla, gulmaya, gulyana, nuruw];
            //foreach (var item in bizimkiler)
            //{
            //    //Downcasting - bir classin miras verdiyi tipinden olaraq yanashilmasi
            //    if (item is Bird bird)
            //    {
            //        //Bird bird = (Bird)item;
            //        bird.Fly();
            //    }
            //    //Bird? bird = item as Bird;
            //    //if (bird is not null)
            //    //{
            //    //    bird.Fly();
            //    //}
            //}

            //Boxing
            //string num = 26.ToString();
            //int num = 26;
            //Object obj = (Object)num;
            //object obj2 = obj;

            //Console.WriteLine(Object.ReferenceEquals(num, obj));


            ////Unboxing
            //int number2 = Convert.ToInt32(obj);
            //int number = int.Parse("77");
            foreach (var item in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (item.Name == "Owl")
                {
                    foreach (var member in item.GetMembers())
                    {
                        Console.WriteLine(member.Name);
                    }
                }
            }
        }
    }
}
