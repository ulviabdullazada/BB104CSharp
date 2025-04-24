using System.Data;
using AdoNET.Helpers;
using AdoNET.Models;
using AdoNET.Repositories.Implements;
using Dapper;
using Microsoft.Data.SqlClient;

namespace AdoNET
{
    internal class Program
    {
        //const string _connString = @"Server=.\SQLEXPRESS;Database=PizzaMizzaConsole;Trusted_Connection=True;TrustServerCertificate=True";
        static void Main(string[] args)
        {
            #region Dapper
            using (var connection = new SqlConnection(@"Server=.\SQLEXPRESS;Database=PizzaMizzaConsole;Trusted_Connection=True;TrustServerCertificate=True"))
            {
                var prods = connection.Query<Product>("SELECT * FROM Products WHERE Name like '%'+@name+'%'", new { name = "a" });
                foreach (var product in prods)
                {
                    Console.WriteLine(product.Id + " " + product.Name);
                }

                //string query = $"INSERT INTO Products VALUES (@name,@price)";
                //connection.Execute(query, new Product
                //{
                //    Name = "Salyami",
                //    Price = 11.9
                //});
            }

            

            #endregion




            //ProductRepository prodRepo = new();

            //prodRepo.Create(new Product
            //{
            //    Name = "Klassiko",
            //    Price = 10.9
            //});



            //List<Product> prods = prodRepo.GetAll();

            //foreach (Product prod in prods)
            //{
            //    Console.WriteLine($"{prod.Id} {prod.Name} {prod.Price}");
            //};

            //var prd = new Product
            //{
            //    Name = Console.ReadLine()!,
            //    Price = Convert.ToDouble(Console.ReadLine())
            //};

            //SqlHelper.Exec($"INSERT INTO Products VALUES (N'{prd.Name}',N'{prd.Price}')");

            //var dt = SqlHelper.Query("SELECT * FROM Products");
            //foreach (DataRow item in dt.Rows)
            //{
            //    Console.WriteLine(item[1]);
            //}
            #region AdoNET
            //using (SqlConnection conn = new(_connString))
            //{
            //    conn.Open();
            //    //using (SqlCommand cmd = new SqlCommand("SELECT * FROM Products", conn))
            //    //{
            //    //    var dataReader = cmd.ExecuteReader();
            //    //    while(dataReader.Read())
            //    //    {
            //    //        Console.WriteLine($"{dataReader[0]} {dataReader[1]} {dataReader[2]}");
            //    //    }
            //    //}
            //    //using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Products", conn))
            //    //{
            //    //    DataTable dt = new DataTable();
            //    //    adapter.Fill(dt);
            //    //    //var a = (dt.Rows[4])[0];
            //    //    foreach (DataRow item in dt.Rows)
            //    //    {
            //    //        Console.WriteLine($"{item["Id"]} {item[1]} {item[2]}");
            //    //    }
            //    //}

            //    using (SqlCommand cmd = new SqlCommand($"INSERT INTO Products VALUES (N'{prd.Name}', N'{prd.Price}')",conn))
            //    {
            //        int result = cmd.ExecuteNonQuery();
            //        if (result > 0)
            //        {
            //            Console.WriteLine("Success");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Fail");
            //        }
            //    }
            //}
            #endregion
            #region Sql injection
            //string username = Console.ReadLine();
            //string password = Console.ReadLine();
            //var dt = SqlHelper.Query($"SELECT top 1 * FROM Users WHERE Username = '{username}' and Password = N'{password}'");

            //if (dt.Rows.Count == 1) 
            //{
            //    Console.WriteLine("Logged in");
            //}
            //else
            //{
            //    Console.WriteLine("User not found");
            //}
            #endregion
        }
    }
}
