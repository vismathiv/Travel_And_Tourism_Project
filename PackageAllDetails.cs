﻿using System;
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
                //Addding all the packages names to the list which will insert directly into the table by admin.
                List<Packages> lstpackages = new List<Packages>()
                {
                    new Packages{PName="Coconut Tree vacation Package",PPrice=7000,PDestination="Maldive",PNoofdays=6,PStartdate=DateTime.Parse("03-01-2022"),PEnddate=DateTime.Parse("05-01-2022"),PcatId=1 },
                    new Packages{PName="Kani Palm Beach Vacation Package",PPrice=10000,PDestination="Maldive",PNoofdays=6,PStartdate=DateTime.Parse("03-01-2022"),PEnddate=DateTime.Parse("05-01-2022"),PcatId=1 },
                    new Packages
                    {
                        PName="Phi-Phi-Island",
                        PPrice=20000,
                        PDestination="Bangkok",
                        PNoofdays=10,
                        PStartdate=DateTime.Parse("01-02-2022"),
                        PEnddate=DateTime.Parse("28-02-2022"),
                        PcatId=1
                    },
                    new Packages
                    {
                        PName="Pattaya Coral Island",
                        PPrice=25000,
                        PDestination="Bangkok",
                        PNoofdays=10,
                        PStartdate=DateTime.Parse("01-03-2022"),
                        PEnddate=DateTime.Parse("31-03-2022"),
                        PcatId=1
                    },
                    new Packages
                    {
                        PName="Phi-Phi-Island",//
                        PPrice=12000,
                        PDestination="Kashmir",
                        PNoofdays=4,
                        PStartdate=DateTime.Parse("01-08-2022"),
                        PEnddate=DateTime.Parse("01-09-2022"),
                        PcatId=2
                    },
                    new Packages
                    {
                        PName="Phi-Phi-Island",//
                        PPrice=15000,
                        PDestination="ooty",
                        PNoofdays=5,
                        PStartdate=DateTime.Parse("01-08-2022"),
                        PEnddate=DateTime.Parse("30-10-2022"),
                        PcatId=2
                    },
                    new Packages
                    {
                        PName="Phi-Phi-Island",//
                        PPrice=18000,
                        PDestination="kulumanar",
                        PNoofdays=4,
                        PStartdate=DateTime.Parse("01-08-2022"),
                        PEnddate=DateTime.Parse("01-09-2022"),
                        PcatId=2
                    },
                };
            }
            catch(Exception ex)
            {
                WriteLine("Error in insertion " + ex.Message);
            }
        }
    }
}
