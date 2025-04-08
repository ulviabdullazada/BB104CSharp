using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrtayaQarisiq.Models
{
    record Person(string Name, string Surname, int Age) { }
    record Student(string Name, string Surname, int Age, int Course) : Person(Name, Surname, Age) { }
}
