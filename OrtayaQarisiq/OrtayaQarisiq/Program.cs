using System.Text;
using System.Threading.Channels;
using OrtayaQarisiq.Models;
//using U = Ulvi;

namespace OrtayaQarisiq
{
    //class Person
    //{
    //    public int B { get; set; }
    //}
    class Int32
    {

    }
    internal class Program : Object
    {
        static void Main(string[] args)
        {
            //var person = new U.Person();
            //mutable - deyishe bilen
            //immutable - deyishe bilmeyen
            //int[] arr = [1, 2, 3, 4];
            //int[] arr2 = [1, 2, 3, 4];
            ////Console.WriteLine(arr);
            //string a = "Salam";
            //string b = "Salam";
            ////arr[3] = 30;
            ////Console.WriteLine(arr[3]);
            ////string a = "Salam";
            ////a[0] = 'S';
            ////Console.WriteLine(a);
            //string c = "S"; //S
            //c += "a";//Sa
            //c += "l";//Sal
            //c += "a";//Sala
            //c += "m";//Salam
            ////Console.WriteLine(Object.ReferenceEquals(a, b));
            //StringBuilder sb = new StringBuilder();
            //sb.Append("S");
            //sb.Append("a");
            //sb.Append("l");
            //sb.Append("a");
            //sb.Append("m");
            //c = sb.ToString();
            //string d = String.Intern(c);
            //Console.WriteLine(Object.ReferenceEquals(a, c));
            //int a = 5;
            //Console.WriteLine(typeof(int));
            //int? id = 5;
            //A(id.Value);
            //if (!id.HasValue)
            //{
            //    Console.WriteLine("Null olmaz");
            //}
            //else
            //{
            //    A(id.Value);
            //}
            //int num = 6;
            //string eded = num > 5 ? "Eded 5den boyukdur" : "Boyuk deyil";
            //Console.WriteLine(eded);

            //int? num = null;
            ////int eded = num ?? 2;
            //num ??= 2;
            //Console.WriteLine(num);

            Person nurlan = new Person("Nurilan", "Hajiyev", 11);
            Person nurlan2 = new Person("Nurlan", "Hajiyev", 11)
            {
                Age = 20,
                
            };
            Person nurlan3 = nurlan with { Age = 20 };
            //nurlan2.Age = 123;
            Console.WriteLine(nurlan);
            Console.WriteLine(nurlan3);
        }
        //public static void A(int num)
        //{
        //    Console.WriteLine(num);
        //}
    }
}

//namespace Ulvi
//{
//    class Person
//    {
//        public int A { get; set; }
//    }

//}
