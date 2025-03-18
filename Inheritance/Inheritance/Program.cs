using Inheritance.Models;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Class
            //Student gulyana = new Student
            //{
            //    Name = "Gulyana",
            //    Surname = "Khalilova",
            //    Age = 20,
            //    Course = 4,
            //    University = "BDU"
            //};
            //gulyana.PrintInfo();
            //Console.WriteLine($"{gulyana.Name} {gulyana.Surname} {gulyana.Age}");

            //Student aysun = CreateStudent("Aysun", "Naghizada",20, 4, "BDU");
            //aysun.PrintInfo();

            //Student zeynab = new Student
            //{
            //    Name = "Zeynab",
            //    Surname = "Asadzada",
            //    Course = 6,
            //    University = "BDU",
            //};

            //Freshman nurlan = new Freshman(437)
            //{
            //    Name = "Nurlan",
            //    Surname = "Hajiyev",
            //    Age = 16,
            //    Course = 1,
            //    University = "BDU"
            //};
            //Employee empl = new Employee("Roya", "Huseynova",20);
            //empl.PrintInfo();
            //int age;
            //Console.WriteLine(empl.Age / 5);
            #endregion

            //int[] arr1 = new int[] { 1, 2, 3, 4 };
            //int[] arr2 = new int[] { 1, 2, 3, 4 };
            ////arr1[0] = 20;
            //Console.WriteLine(arr1 == arr2);

            //int num1 = 5;
            //int num2 = 5;
            //Console.WriteLine(num1 == num2);

            //float maas;
            //Bonus(out float maas);
            //Console.WriteLine(maas);
            //int num;
            //int.TryParse(Console.ReadLine(), out int num);
            //Console.WriteLine(num);
            string word = "Salam";
            ToBigA(ref word);
            Console.WriteLine(word);
        }

        static void ToBigA(ref string text)
        {
            string result = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a')
                {
                    result += 'A';
                }
                else
                {
                    result += text[i];
                }
            }
            text = result;
        }

        //static void Bonus(out float salary)
        //{
        //    salary = 4000;
        //    //salary += salary * 0.25f;
        //}




        //static Student CreateStudent(string name, string surname, byte age, byte course, string uni)
        //{
        //    Student std = new Student
        //    {
        //        Name = name,
        //        Surname = surname,
        //        Age = age,
        //        Course = course,
        //        University = uni
        //    };
        //    return std;
        //}
    }
}
