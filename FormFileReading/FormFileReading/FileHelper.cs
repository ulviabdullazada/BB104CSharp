using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormFileReading.Models;
using Newtonsoft.Json;

namespace FormFileReading
{
    static class FileHelper
    {
        private static string StudentsPath
        {
            get
            {
                DirectoryInfo di = new DirectoryInfo(Directory.GetCurrentDirectory());
                string path = Path.Combine(di.Parent.Parent.Parent.FullName, "students.json");
                return path;
            }
        }

        public static List<Student> GetStudents()
        {
            using (StreamReader sr = new(StudentsPath))
            {
                string stds = sr.ReadLine();
                return JsonConvert.DeserializeObject<List<Student>>(stds);
            }
        }
        public static void AddStudent(Student std)
        {
            List<Student> students = GetStudents();
            students.Add(std);
            using (StreamWriter sw = new(StudentsPath))
            {
                sw.WriteLine(JsonConvert.SerializeObject(students));
            }
        }
    }
}
