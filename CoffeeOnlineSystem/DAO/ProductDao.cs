using CoffeeOnlineSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CoffeeOnlineSystem.DAO
{
    public class ProductDao
    {
        private Coffee context = null;
        public ProductDao()
        {
            context = new Coffee();
        }
        public IEnumerable<Product> GetProducts()
        {
            return context.Products.ToList();
        }
        /*  public List<Product> getProduct(int? id)
          {
              DBConection db;
              string sql;
              if (id == null)
              {
                  sql = "select * from products";
              }
              else
              {
                  sql = "select * from products where IDProduct=" + id;
              }
              List<Product> proList = new List<Product>();
              DataTable dt = new DataTable();
              SqlConnection con = db.GetConnection();
              SqlDataAdapter da = new SqlDataAdapter(sql, con);
              con.Open();
              da.Fill(dt);
              da.Dispose();
              con.Close();
              Product temp;
              for (int i = 0; i < dt.Rows.Count; i++)
              {
                  temp = new Product();
                  temp.IDProduct = Convert.ToInt32(dt.Rows[i]["IDProduct"].ToString());
                  temp.IDCategory = Convert.ToInt32(dt.Rows[i]["IdCategory"].ToString());
                  temp.nameProduct = Convert.ToInt32(dt.Rows[i]["nameProduct"].ToString());
                  temp.a = Convert.ToInt32(dt.Rows[i]["nameProduct"].ToString());

                  temp.Image = dt.Rows[i][""].ToString();
                  temp.Price = Convert.ToDouble(dt.Rows[i]["price"].ToString());
                  temp.Description = dt.Rows[i]["descripttion"].ToString();
                  temp.IDCatogory = Convert.ToInt32(dt.Rows[i]["IDCategory"].ToString());
                  proList.Add(temp);
              }
              return proList;
          }*/

    }
}