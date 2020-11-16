namespace CoffeeOnlineSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        [Key]
        [StringLength(50)]
        public string username { get; set; }

        [StringLength(32)]
        public string password { get; set; }

        public int? role { get; set; }
    }
}
