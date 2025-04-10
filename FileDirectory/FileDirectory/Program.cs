using System.Text;
using Newtonsoft.Json;

namespace FileDirectory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string path = Path.Combine("C:", "Users", "Ulvi Abdullazada", "Desktop", "YeniQovluq", "a.txt");
            ////File.Create(desktopPath);
            //using (StreamWriter sw = new StreamWriter(path, true))
            //{
            //    sw.WriteLine("Salam");
            //}
            //using (StreamReader sr = new StreamReader(path))
            //{
            //    Console.WriteLine(sr.ReadLine());
            //}
            DirectoryInfo di = new DirectoryInfo(Directory.GetCurrentDirectory());
            string path = Path.Combine(di.Parent.Parent.Parent.FullName,"students.json");
            if (!File.Exists(path))
                File.Create(path).Close();
            int[] nums = [1, 2, 3, 4, 5];
            //StringBuilder sb = new StringBuilder();
            //sb.Append('[');
            //foreach (int i in nums) 
            //{
            //    sb.Append(i + ", ");
            //}
            //sb.Remove(sb.Length - 2, 2);
            //sb.Append(']');

            //using (StreamWriter sw = new(path))
            //{
            //    //sw.WriteLine(sb.ToString());
            //    sw.WriteLine(new
            //    {
            //        Name = "Murad",
            //        Surname = "Nurmammadov"
            //    });
            //}
            using (StreamReader sr = new(path))
            {
                string arr = sr.ReadToEnd();
                var obj = JsonConvert.DeserializeObject<dynamic>(arr);
                Console.WriteLine(obj.Name);
                //foreach (var item in newNums)
                //{
                //    Console.WriteLine(item);
                //}
            }
            
        }
    }
}
