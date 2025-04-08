namespace EnumDersi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dayOfWeek = 6;
            foreach (var item in Enum.GetValues(typeof(Weekdays)))
            {
                if ((int)item == dayOfWeek)
                {
                    Console.WriteLine(item);
                    break;
                }
            }
            //switch (dayOfWeek)
            //{
            //    case 1:
            //        Console.WriteLine(Weekdays.Mondy);
            //        break;
            //    default:
            //        break;
            //}
        }
    }
}
