using Delegate.Models;

namespace Delegate;
public delegate bool Leyla(int eded);
public delegate string Roya(string num);
internal class Program
{
    static int[] nums = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
    static void Main(string[] args)
    {
        //Console.WriteLine(IsEven(5));
        //PrintNumbers(IsEven);
        //PrintNumbers(IsDivideBy3);
        //Leyla l = delegate (int num) //anonym function
        //{
        //    return num % 5 == 0;
        //};
        //Leyla l = nums => nums % 5 == 0; //lambda expression || arrow function
        //PrintNumbers(l);
        //PrintNumbers(x => {
        //    return x % 2 == 1;
        //});
        //PrintNumbers(x => x % 2 == 1);
        //Print("emiliyA", x => Char.ToUpper(x[0]) + x.Substring(1).ToLower());

        //Func<> -> Parametr sayini, tipini ve donush tiplerini biz veririk;
        //Action<> -> Parametrlerinin say ve tipini biz veririk, voiddir
        //Predicate<> -> 1 parametr qebul edir ve bool dondurur.
        List<Student> students = [
            new Student("Gunel", "Shikarova", 23),
            new Student("Gulyana", "Khalilova", 20),
            new Student("Zeyneb", "Asadzada", 27),
            new Student("Gulmaya", "Jumayeva", 21),
            new Student("Murad", "Nurmammadov", 21)
        ];
        students.FindAll(x => x.Name.StartsWith("G")).ForEach(x => Console.WriteLine(x));
    }



    //static void PrintNumbers(Predicate<int> method)
    //{
    //    foreach (var item in nums)
    //    {
    //        if (method(item))
    //        {
    //            Console.WriteLine(item);
    //        }
    //    }
    //}
    //static void Print(string text, Roya method)
    //{
    //    Console.WriteLine(method(text));
    //}
    //static bool IsEven(int num)
    //{
    //    return num % 2 == 0;
    //}
    //static bool IsDivideBy3(int num) => num % 3 == 0;
}
