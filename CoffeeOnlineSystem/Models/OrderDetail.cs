namespace CoffeeOnlineSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrderDetail
    {
        [Key]
        public int IDOrderDetails { get; set; }

        public int? IDProduct { get; set; }

        public int? IDOrder { get; set; }

        public int? quantity { get; set; }

        public double? salePrice { get; set; }
    }
}
