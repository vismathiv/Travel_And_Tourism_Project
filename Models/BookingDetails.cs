using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Travel_And_Tourism_Project.Models
{
    public partial class BookingDetails
    {
        public int BookingId { get; set; }
        public int? PId { get; set; }
        public int? CId { get; set; }
        public int? Noofadult { get; set; }
        public int? Noofchild { get; set; }
        public DateTime? BookingDate { get; set; }
        public int? PdId { get; set; }
        public int? PayId { get; set; }
        public string BookingStatus { get; set; }

        public virtual Customer C { get; set; }
        public virtual Packages P { get; set; }
        public virtual Payment Pay { get; set; }
        public virtual PackageDetails Pd { get; set; }
        public string test { get; set; }
    }
}
