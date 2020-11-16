using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CoffeeOnlineSystem.Models
{
    public class searchdao
    {
        COFFEEEntitiesss coffee = new COFFEEEntitiesss();
        public List<Product> searchAll(string searchString)
        {
            searchString = "%" + searchString + "%";
            string query = "SELECT * FROM Product INNER JOIN Category ON Product.IDCategory = Category.IDCategory " +                 
                " WHERE Product.nameProduct like @searchString OR Category.nameCategory LIKE @searchString";
            List<Product> lstProduct = coffee.Products.SqlQuery(query, new SqlParameter("searchString", searchString)).ToList();
            return lstProduct;
        }
        public List<Product> searchProduct(string searchString)
        {
            List<Product> lstProduct = coffee.Products.Where(p => p.nameProduct.Contains(searchString.ToString())).ToList();
            return lstProduct;
        }
        public List<Product> searchCategory(string searchString)
        {
            searchString = "%" + searchString + "%";
            string query = "SELECT * FROM Product INNER JOIN Category ON Product.IDCategory = Category.IDCategory " +
                " WHERE Product.nameProduct like @searchString OR Category.nameCategory LIKE @searchString";
            List<Product> lstProduct = coffee.Products.SqlQuery(query, new SqlParameter("searchString", searchString)).ToList();
            return lstProduct;
        }
    }
}