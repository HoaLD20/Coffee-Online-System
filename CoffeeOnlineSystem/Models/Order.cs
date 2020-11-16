namespace CoffeeOnlineSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        [Key]
        public int IDOrder { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dateOrder { get; set; }

        public int? IDCustomer { get; set; }

        public int? IDEmployee { get; set; }

        public int? IDPayment { get; set; }

        public double? surchange { get; set; }

        public int? statusPaid { get; set; }
    }
}
