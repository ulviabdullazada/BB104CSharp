namespace Class
{
    class Student
    {
        //field
        public string Name;
        public string Surname;
        public byte Age;

        //constructor
        //1. Sadece obyekt yaranan zaman ishe dushur.
        //Obyektin memberlarini ramda yaradir.
        //2. Hemishe class adi ile eyni adda olur
        //3. Return type-i olmur
        //4. Biz yazsaq da yazmasaq da her bir classin bosh
        //consturctoru olur
        public Student() //parameterless constructor
        {
        }
        public Student(string name) : this()
        {
            if (name.Length > 2)
            {
                Name = name;
            }
            else
            {
                Console.WriteLine("Adin uzunlugu 3 simvoldan cox olmalidir");
            }
        }
        public Student(string name, string surname) : this(name)
        {
            if (surname.Length > 2)
            {
                Surname = surname;
            }
            else
            {
                Console.WriteLine("Soyadin uzunlugu 2den cox olmalidir");
            }
        }
        public Student(string ad, string surname, byte age)
            :this(ad, surname)
        {
            if (age > 15)
            {
                Age = age;
            }
            else
            {
                Console.WriteLine("Yash duzgun daxil edilmeyib");
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{Name} {Surname} {Age}");
        }

    }
    internal class Program
    {
        public string ProgramName;
        static void Main(string[] args)
        {
            #region Without object
            //string n01_nazilaName = "Nazila";
            //string n01_nazilaSurname = "Taghiyeva";
            //int n01_nazilaAge = 20;

            //string n02_sakinaName = "Sakina";
            //string n02_sakinaSurname = "Aliyeva";
            //int n02_sakinaAge = 20;
            #endregion

            #region anonymous objects
            //object n01_nazila = new
            //{
            //    Name = "Nazila",
            //    Surname = "Taghiyeva",
            //    Age = 20
            //};
            //object n02_sakina = new
            //{
            //    Ad = "Sakina",
            //    Surname = "Aliyeva",
            //    Age = 20
            //};
            ////object[] students = [n01_nazila, n02_sakina];
            //Console.WriteLine(n01_nazila.Name);
            #endregion

            #region Class object
            Student nazila = new Student();
            nazila.Name = "Nazila";
            nazila.Surname = "Taghiyeva";
            nazila.Age = 20;

            Student sakina = new Student("Sakina")
            {
                Surname = "Aliyeva",
                Age = 20
            };

            Student emilia = new Student("Emilia", "Zeynalzada", 121)
            {
                Name = "Emilya"
            };
            Student gunel = new Student("Gunel", "Shikarova");
            gunel.Age = 22;

            gunel.PrintInfo();
            emilia.PrintInfo();

            //Console.WriteLine(emilia.Name + " " + emilia.Surname);

            //Console.WriteLine(emilia.Name);
            //Console.WriteLine(sakina.Name + " " + sakina.Surname + " " + sakina.Age);
            //Console.WriteLine($"{sakina.Name} {sakina.Surname} {sakina.Age}");
            //Console.WriteLine("{1} {0} {2}",sakina.Name, sakina.Surname, sakina.Age);
            #endregion


            //Console.WriteLine(GiveBonus(1000));
        }

        static float GiveBonus(int salary)
        {
            float bonus = CalculatePercent(salary, 10);
            if (bonus == -1)
            {
                return -1f;
            }
            return salary + bonus;
        }


        static float CalculatePercent(int num, int percent)
        {
            if (percent > 100 || percent < 0 || num < 0)
            {
                Console.WriteLine("Data duzgun deyil");
                return -1f;
            }
            return num * percent / 100;
        }
    }
}
