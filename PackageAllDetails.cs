using System;
using System.Collections.Generic;
using System.Text;
using Travel_And_Tourism_Project.Models;
using static System.Console;
using static System.Convert;
namespace Travel_And_Tourism_Project
{
    public class PackageAllDetails
    {
        //first categories

        public void insertpackagecategories()
        {
            try
            {
                List<PackageCategory> lstcategories = new List<PackageCategory>()
                {
                    new PackageCategory{PcatName = "Summer Category", PcatDescription = "This packages contains all summer season related travels"},
                    new PackageCategory{PcatName="Winter Category",PcatDescription="This packages contains all Winter season related travels"},
                    new PackageCategory{PcatName="Rainy Category",PcatDescription ="This packages contains all Rainy season related travels"},
                    new PackageCategory{PcatName="Monsoon Category",PcatDescription="This packages contains all Monsoon season related travels"},
                    new PackageCategory{PcatName="Spring Category",PcatDescription="This packages contains all spring season related travels"},
                    new PackageCategory{PcatName="Autumn Category",PcatDescription="This packages contains all Autumn season related travels"}
                };
            }
            catch (Exception ex)
            {
                WriteLine("Error in insertion "+ex.Message);
            }
        }

        public void insertpackages()
        {
            try
            {
                List<Packages> lstpackages = new List<Packages>()
                {
                    new Packages{PName="Coconut Tree vacation Package",PPrice=7000,PDestination="Maldive",PNoofdays=6,PStartdate=DateTime.Parse("03-01-2022"),PEnddate=DateTime.Parse("05-01-2022"),PcatId=1 },
                    new Packages{PName="Kani Palm Beach Vacation Package",PPrice=10000,PDestination="Maldive",PNoofdays=6,PStartdate=DateTime.Parse("03-01-2022"),PEnddate=DateTime.Parse("05-01-2022"),PcatId=1 },
                    new Packages{PName="Goa Package of Kani Palm Beach Vacation Package",PPrice=10000,PDestination="Goa",PNoofdays=3,PStartdate=DateTime.Parse("03-01-2022"),PEnddate=DateTime.Parse("05-01-2022"),PcatId=1 },
                    new Packages{PName="Goa Package of Kani Palm Beach Vacation Package",PPrice=10000,PDestination="Goa",PNoofdays=3,PStartdate=DateTime.Parse("03-01-2022"),PEnddate=DateTime.Parse("05-01-2022"),PcatId=1 },
                    new Packages{PName="Bangkok Package",PPrice=40000,PDestination="Bangkok",PNoofdays=6,PStartdate=DateTime.Parse("03-01-2022"),PEnddate=DateTime.Parse("05-01-2022"),PcatId=1 },
                    new Packages{PName="Maldive Package of 5 days",PPrice=7000,PDestination="Maldive",PNoofdays=6,PStartdate=DateTime.Parse("03-01-2022"),PEnddate=DateTime.Parse("05-01-2022"),PcatId=1 },
                    new Packages{PName="Maldive Package of 5 days",PPrice=7000,PDestination="Maldive",PNoofdays=6,PStartdate=DateTime.Parse("03-01-2022"),PEnddate=DateTime.Parse("05-01-2022"),PcatId=1 },
                    new Packages{PName="Maldive Package of 5 days",PPrice=7000,PDestination="Maldive",PNoofdays=6,PStartdate=DateTime.Parse("03-01-2022"),PEnddate=DateTime.Parse("05-01-2022"),PcatId=1 }
                };
            }
            catch(Exception ex)
            {
                WriteLine("Error in insertion " + ex.Message);
            }
        }
    }
}
