using Sealed.Exceptions;
using Sealed.Models;

namespace Sealed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool isNum = Parse(Console.ReadLine(), out int result);
            //if (isNum)
            //{
            //    Console.WriteLine("Number is " + result);
            //}
            //else
            //{
            //    Console.WriteLine("Number format is wrong");
            //}
            //try
            //{
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    return;
            //    Console.WriteLine(num/0);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Input duzgun formatda deyil");
            //}
            //catch(OverflowException)
            //{
            //    Console.WriteLine("Eded ya cox boyukdur ya da cox kicikdir");
            //}
            //catch (Exception a)
            //{
            //    Console.WriteLine(a.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Finally");
            //}
            try
            {
                Intern nurlan = new(10);
            }
            catch (WorkerOverTimeException)
            {
                Console.WriteLine("Mehkemeye muraciet edin");
            }
            catch (Exception)
            {
                Console.WriteLine("Xeta bash verdi zehmet olmasa bizimle elaqeye kechin");
            }
        }
        public static bool Parse(string input, out int result)
        {
            try
            {
                result = Convert.ToInt32(input);
                return true;
            }
            catch (Exception)
            {
                result = 0;
                return false;
            }
        }
    }
}
