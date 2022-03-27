using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Travel_And_Tourism_Project.Models
{
    public partial class PackageDetails
    {
        public PackageDetails()
        {
            BookingDetails = new HashSet<BookingDetails>();
        }

        public int PdId { get; set; }
        public int? PId { get; set; }
        public string PdDescription { get; set; }
        public int? PdDays { get; set; }

        public virtual Packages P { get; set; }
        public virtual ICollection<BookingDetails> BookingDetails { get; set; }
    }
}
