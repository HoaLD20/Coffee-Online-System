using CoffeeOnlineSystem.Models;
using System;
using System.Collections.Generic;
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
    }

}