using EFCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var sql = new PizzaMizzaConsoleContext())
            {
                //sql.Products.Add(new Product
                //{
                //    Name = "Mista",
                //    Price = 11.9m
                //});
                ////tracking mechanism
                //sql.SaveChanges();
                //foreach (var item in sql.Products.ToList())
                //{
                //    Console.WriteLine(item.Id +" " + item.Name);
                //}
                IQueryable<Product> query = sql.Products.Where(prod => prod.Name.StartsWith("sa"));
                //Console.WriteLine(query.ToQueryString());
                Console.WriteLine(query.FirstOrDefault().Name);
            }
        }
    }
}
