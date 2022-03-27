using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Travel_And_Tourism_Project.Models
{
    public partial class Customer
    {
        public Customer()
        {
            BookingDetails = new HashSet<BookingDetails>();
            Payment = new HashSet<Payment>();
        }

        public int CId { get; set; }
        public int? PId { get; set; }
        public string CFname { get; set; }
        public string CLname { get; set; }
        public int? CAge { get; set; }
        public string CPhone { get; set; }
        public string CEmail { get; set; }
        public string CAddress { get; set; }
        public int? Noofpersons { get; set; }

        public virtual Packages P { get; set; }
        public virtual ICollection<BookingDetails> BookingDetails { get; set; }
        public virtual ICollection<Payment> Payment { get; set; }
    }
}
