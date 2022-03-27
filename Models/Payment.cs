using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Travel_And_Tourism_Project.Models
{
    public partial class Payment
    {
        public Payment()
        {
            BookingDetails = new HashSet<BookingDetails>();
        }

        public int PayId { get; set; }
        public string PayType { get; set; }
        public int? PayPrice { get; set; }
        public DateTime? PayDate { get; set; }
        public int? CId { get; set; }

        public virtual Customer C { get; set; }
        public virtual ICollection<BookingDetails> BookingDetails { get; set; }
    }
}
