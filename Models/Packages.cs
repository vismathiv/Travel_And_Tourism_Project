using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Travel_And_Tourism_Project.Models
{
    public partial class Packages
    {
        public Packages()
        {
            BookingDetails = new HashSet<BookingDetails>();
            Customer = new HashSet<Customer>();
            PackageDetails = new HashSet<PackageDetails>();
        }

        public int PId { get; set; }
        public string PName { get; set; }
        public int? PPrice { get; set; }
        public string PDestination { get; set; }
        public int? PNoofdays { get; set; }
        public DateTime? PStartdate { get; set; }
        public DateTime? PEnddate { get; set; }
        public int? PcatId { get; set; }

        public virtual PackageCategory Pcat { get; set; }
        public virtual ICollection<BookingDetails> BookingDetails { get; set; }
        public virtual ICollection<Customer> Customer { get; set; }
        public virtual ICollection<PackageDetails> PackageDetails { get; set; }
    }
}
