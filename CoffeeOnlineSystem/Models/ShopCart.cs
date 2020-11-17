using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoffeeOnlineSystem.Models
{
    public class ShopCart
    {
        public string ItemId { get; set; }

        public int CartId { get; set; }

        public int Quantity { get; set; }

        public System.DateTime DateCreated { get; set; }

        public int ProductId { get; set; }

        public int Total { get; set; }

        public Product Product { get; set; }

    }
}