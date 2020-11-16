namespace CoffeeOnlineSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [Key]
        public int IDProduct { get; set; }

        public int? IDCategory { get; set; }

        [StringLength(50)]
        public string nameProduct { get; set; }

        public int? available { get; set; }

        [StringLength(100)]
        public string imageUrl { get; set; }

        public double? price { get; set; }

        [StringLength(500)]
        public string description { get; set; }

        [Column(TypeName = "image")]
        public byte[] photo { get; set; }

        public int? status { get; set; }

    }
}
