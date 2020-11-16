namespace CoffeeOnlineSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [Key]
        public int IDEmployee { get; set; }

        [StringLength(100)]
        public string fullnameEmp { get; set; }

        [StringLength(15)]
        public string phoneEmp { get; set; }

        [StringLength(100)]
        public string emailEmp { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DOBEmp { get; set; }

        [StringLength(10)]
        public string genderEmp { get; set; }

        [StringLength(50)]
        public string usernameEmp { get; set; }

        [StringLength(50)]
        public string position { get; set; }

        public int? statusEmp { get; set; }
    }
}
