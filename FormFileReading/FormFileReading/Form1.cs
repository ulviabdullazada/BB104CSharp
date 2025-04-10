using System.Data;
using FormFileReading.Models;
using Newtonsoft.Json;

namespace FormFileReading
{
    public partial class Form1 : Form
    {
        public static bool IsAuthenticated { get; set; } = false;
        private string StudentsPath
        {
            get{
                DirectoryInfo di = new DirectoryInfo(Directory.GetCurrentDirectory());
                string path = Path.Combine(di.Parent.Parent.Parent.FullName, "students.json");
                return path;
            }
        } 
        

        public Form1()
        {
            InitializeComponent();
            Hide();
            if (!File.Exists(StudentsPath))
                File.Create(StudentsPath).Close();
            _fillTable();
            Login login = new();
            login.Show();
        }
        private void _fillTable()
        {
            var students = FileHelper.GetStudents();
            //dataGridView1.Columns.Clear();
            //dataGridView1.Rows.Clear();
            //table.Columns.Add("Id", "Id");
            //table.Columns.Add("Name", "Ad");
            //table.Columns.Add("Surname", "Soyad");
            //table.Columns.Add("Age", "Yash");
            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Name");
            dt.Columns.Add("Surname");
            dt.Columns.Add("Age");
            foreach (var student in students)
            {
                dt.Rows.Add(student.Id, student.Name, student.Surname, student.Age);
            }
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name.Text) ||
                string.IsNullOrWhiteSpace(surname.Text) ||
                string.IsNullOrWhiteSpace(age.Text))
            {
                MessageBox.Show("Xanalari duzgun doldurun");
            }
            else
            {
                Student std = new Student
                {
                    Name = name.Text,
                    Surname = surname.Text,
                    Age = Convert.ToInt32(age.Text)
                };
                FileHelper.AddStudent(std);
                name.Clear();
                surname.Clear();
                age.Clear();
                _fillTable();
            }
        }
    }
}
