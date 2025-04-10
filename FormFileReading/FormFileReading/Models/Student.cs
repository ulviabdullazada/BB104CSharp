using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormFileReading.Models
{
    public class Student
    {
        public int Id { get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public Student()
        {
            Random r = new Random();
            Id = r.Next(0, 1000);
        }
    }
}
