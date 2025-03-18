namespace RefOut
{
    class Program
    {
        static void Main()
        {
            int b = 17;
            Sekine(b);
            Console.WriteLine(b);
        }

        static int Sekine(int b)
        {
            b = 20;
            return b;
        }
    }
}
