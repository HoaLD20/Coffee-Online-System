namespace CoffeeOnlineSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        [Key]
        public int IDCustomer { get; set; }

        [StringLength(100)]
        public string fullnameCus { get; set; }

        [StringLength(15)]
        public string phoneCus { get; set; }

        [StringLength(100)]
        public string emailCus { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DOBCus { get; set; }

        [StringLength(10)]
        public string genderCus { get; set; }

        [StringLength(50)]
        public string usernameCus { get; set; }

        public int? statusCus { get; set; }
    }
}
