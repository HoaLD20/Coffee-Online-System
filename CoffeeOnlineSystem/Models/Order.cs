//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CoffeeOnlineSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int IDOrder { get; set; }
        public Nullable<System.DateTime> dateOrder { get; set; }
        public Nullable<int> IDCustomer { get; set; }
        public Nullable<int> IDEmployee { get; set; }
        public Nullable<int> IDPayment { get; set; }
        public Nullable<double> surchange { get; set; }
        public Nullable<int> statusPaid { get; set; }
    }
}
