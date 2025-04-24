using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdoNET.Helpers;
using AdoNET.Models;
using AdoNET.Repositories.Interfaces;

namespace AdoNET.Repositories.Implements
{
    internal class ProductRepository : IRepository<Product>
    {
        public void Create(Product model)
        {
            SqlHelper.Exec($"INSERT INTO Products VALUES (N'{model.Name}',N'{model.Price}')");
        }

        public void Delete(int id)
        {
            if (id > 0)
                SqlHelper.Exec($"DELETE Products WHERE Id = {id}");
            else
                throw new ArgumentException();
        }

        public List<Product> GetAll()
        {
            var dt = SqlHelper.Query("SELECT * FROM Products");
            List<Product> list = new List<Product>();
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new Product
                {
                    Id = Convert.ToInt32(item["Id"]),
                    Name = item["Name"].ToString()!,
                    Price = Convert.ToDouble(item["Price"]),
                });
            }
            return list;
        }

        public Product GetById(int id)
        {
            var dt = SqlHelper.Query($"SELECT TOP 1 * FROM Products WHERE Id = {id}");
            if (dt.Rows.Count != 1) throw new Exception();
            return new Product
            {
                Id = Convert.ToInt32(dt.Rows[0]["Id"]),
                Name = dt.Rows[0]["Name"].ToString()!,
                Price = Convert.ToDouble(dt.Rows[0]["Price"]),
            };
        }

        public void Update(int id, Product model)
        {
            throw new NotImplementedException();
        }
    }
}
