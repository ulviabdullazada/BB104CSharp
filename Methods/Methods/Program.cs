namespace Methods
{
    internal class Program
    {
        //Main methodu esas methoddur. Kodlarinizi burda yazin
        static void Main(string[] args)
        {
            //dynamic num = "Salam";
            //Console.WriteLine(num.Length);
            //num = 77;
            //Console.WriteLine(num * 4);

            //int count = FindSymbolCount("Baki Dovlet Universiteti e",'E');
            //FindSymbolCount("Code Academy aaa",'a');
            ////SayHi();
            ////SayHi();
            ////SayHi();
            ////Console.WriteLine(count);
            //if (count > 3)
            //{
            //    Console.WriteLine("He halaldi");
            //}
            //else
            //{
            //    Console.WriteLine("En az 4 defe olmalidir");
            //}
            //int i = SayHi();
            //byte say = FindSymbolCount();//2
            //Console.WriteLine(say);
            //byte say = 2;
            //int[] nums = { 1, 2, 10, -4, 2, 7, 9 };
            //Console.WriteLine(Min(
            //    arr: [1,2,3,4,5,6,6,7,8,8,9,9,9]
            //    ));
            //Print();
            //Print(3, "Nurlan");
            //Print("Nurlan", 3);

            Print("Leyla");
        }

        static void Print()
        {
            Console.WriteLine("No parameter");
        }
        static void Print(string text = "Salam")
        {
            Console.WriteLine("Default parameter");
        }
        static void Print(params string[] texts)
        {
            Console.WriteLine("Params");
        }



        //static void Print(int num, string text)
        //{
        //    Console.WriteLine(num + " " + text);
        //}
        //static void Print(string text, int num)
        //{
        //    for (int i = 0; i < num; i++)
        //    {
        //        Console.WriteLine(text);
        //    }
        //}




        static int Min(string name = "Salam", params int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            return min;
        }
        static byte FindSymbolCount(string text="asd", char sym='a')
        {
            string input = text;
            byte count = 0;
            char search = Char.ToLower(sym);
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == search || input[i] == Char.ToUpper(search))
                {
                    count++;
                }
            }
            //Console.WriteLine(count);
            return count;
        }

        static void SayHi()
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i + " defe Salam");
            }
        }
    }
}
