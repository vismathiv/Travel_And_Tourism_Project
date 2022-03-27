using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Travel_And_Tourism_Project.Models
{
    public partial class PackageCategory
    {
        public PackageCategory()
        {
            Packages = new HashSet<Packages>();
        }

        public int PcatId { get; set; }
        public string PcatName { get; set; }
        public string PcatDescription { get; set; }

        public virtual ICollection<Packages> Packages { get; set; }
    }
}
