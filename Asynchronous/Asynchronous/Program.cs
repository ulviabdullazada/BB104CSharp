using System.Diagnostics;

namespace Asynchronous
{
    internal class Program
    {
        private static object Asiman = new();
        static void Main(string[] args)
        {
            //Console.ForegroundColor = ConsoleColor.Black;
            //Console.BackgroundColor = ConsoleColor.White;
            //Thread t1 = new Thread(() =>
            //{
            //    for (int i = 0; i < 5000; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //});
            //Thread t2 = new Thread(() =>
            //{
            //    for (int i = 5000; i < 10000; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //});
            //t1.IsBackground = true;
            //t2.IsBackground = true;
            //t1.Start();
            //t1.Join();
            //Console.WriteLine("asdasd");
            //t2.Start();
            //Parallel.Invoke(() =>
            //{
            //    for (int i = 5000; i < 10000; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}, () =>
            //{
            //    for (int i = 0; i < 5000; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //});
            //Parallel.ForEach([1, 2, 3, 4, 5, 6, 7, 8, 9, 10], x =>
            //{
            //    Console.WriteLine(x);
            //});

            //int num = 0;
            //Thread t1 = new Thread(() =>
            //{
            //    for (int i = 0; i < 100000; i++)
            //    {
            //        lock (Asiman)
            //        {
            //            num++;
            //        }
            //    }
            //});
            //Thread t2 = new Thread(() =>
            //{
            //    for (int i = 0; i < 100000; i++)
            //    {
            //        lock (Asiman)
            //        {
            //            num--;
            //        }
            //    }
            //});
            //t1.Start();
            //t2.Start();
            //Console.WriteLine(num);
            //Stopwatch sw = new();
            //sw.Start();
            ////SeherYemeyi();
            ////sw.Stop();
            ////Console.WriteLine(sw);
            //SeherYemeyiAsync().Wait();
            //sw.Stop();
            //Console.WriteLine(sw);
            Console.WriteLine(TryParseAsync("asdasd").Result);
        }

        static async Task YumurtaQaynatAsync()
        {
            Console.WriteLine("Suyu qazana tok");
            Console.WriteLine("2 yumurtani qazana qoy");
            Console.WriteLine("Yemeyi qaynat");
            await Task.Delay(8000);
            Console.WriteLine("Yumurta hazirdir.");
        }
        static async Task CayQaynatAsync()
        {
            Console.WriteLine("Suyu caydana tok");
            Console.WriteLine("Suyu qaynat");
            await Task.Delay(5000);
            Console.WriteLine("Su qaynadi cay hazirdi");
        }
        static async Task SufreniHazirlaAsync()
        {
            await Task.Delay(1000);
            Console.WriteLine("Sufre Hazirdi");
        }
        static async Task SeherYemeyiAsync()
        {
            await Task.WhenAll(YumurtaQaynatAsync(), CayQaynatAsync(), SufreniHazirlaAsync());
            //await YumurtaQaynatAsync();
            //await CayQaynatAsync();
            //await SufreniHazirlaAsync();
            //Console.WriteLine("Nush");
        }
        static async Task<int> TryParseAsync(string text)
        {
            return await Task.Run<int>(() =>
            {
                int.TryParse(text, out int result);
                return result;
            });
        }
        static void SeherYemeyi()
        {
            YumurtaQaynat();
            CayQaynat();
            SufreniHazirla();
            Console.WriteLine("Nush");
        }
        static void YumurtaQaynat()
        {
            Console.WriteLine("Suyu qazana tok");
            Console.WriteLine("2 yumurtani qazana qoy");
            Console.WriteLine("Yemeyi qaynat");
            Thread.Sleep(8000);
            Console.WriteLine("Yumurta hazirdir.");
        }
        static void CayQaynat()
        {
            Console.WriteLine("Suyu caydana tok");
            Console.WriteLine("Suyu qaynat");
            Thread.Sleep(5000);
            Console.WriteLine("Su qaynadi cay hazirdi");
        }
        static void SufreniHazirla()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Sufre Hazirdi");
        }
    }
}
