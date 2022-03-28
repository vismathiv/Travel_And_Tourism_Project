using System;
using System.Collections.Generic;
using System.Text;
using Travel_And_Tourism_Project.Models;
using static System.Console;
using static System.Convert;
using System.Linq;

namespace Travel_And_Tourism_Project
{

    public class PackageAllDetails
    {
        //first categories
        TourismManagementContext dbcontext = new TourismManagementContext();

        public void insertpackagecategories()
        {
            try
            {
                //Adding Package Categories to the List of Package Category called lstcategories
                List<PackageCategory> lstcategories = new List<PackageCategory>()
                {
                    new PackageCategory{PcatName = "Summer Category", PcatDescription = "This packages contains all summer season related travels"},
                    new PackageCategory{PcatName="Winter Category",PcatDescription="This packages contains all Winter season related travels"},
                    new PackageCategory{PcatName="Rainy Category",PcatDescription ="This packages contains all Rainy season related travels"},
                    new PackageCategory{PcatName="Monsoon Category",PcatDescription="This packages contains all Monsoon season related travels"},
                    new PackageCategory{PcatName="Spring Category",PcatDescription="This packages contains all spring season related travels"},
                    new PackageCategory{PcatName="Autumn Category",PcatDescription="This packages contains all Autumn season related travels"}
                };
                dbcontext.PackageCategory.AddRange(lstcategories);
                dbcontext.SaveChanges();
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
                    //Package Price is Per Person
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
                        PName="Exotic Kashmir with Sonmarg",//
                        PPrice=12000,
                        PDestination="Kashmir",
                        PNoofdays=4,
                        PStartdate=DateTime.Parse("01-08-2022"),
                        PEnddate=DateTime.Parse("01-09-2022"),
                        PcatId=2
                    },
                    new Packages
                    {
                        PName="Magnificent Ooty Package",//
                        PPrice=15000,
                        PDestination="Ooty",
                        PNoofdays=5,
                        PStartdate=DateTime.Parse("01-08-2022"),
                        PEnddate=DateTime.Parse("30-10-2022"),
                        PcatId=2
                    },
                    new Packages
                    {
                        PName="Sweet Mist Of Manali",//
                        PPrice=18000,
                        PDestination="Kulumanali",
                        PNoofdays=4,
                        PStartdate=DateTime.Parse("01-08-2022"),
                        PEnddate=DateTime.Parse("01-09-2022"),
                        PcatId=2
                    },
                     new Packages
                    {
                        PName="Mist Munnar Package",//
                        PPrice=15000,
                        PDestination="Munnar",
                        PNoofdays=5,
                        PStartdate=DateTime.Parse("01-07-2022"),
                        PEnddate=DateTime.Parse("01-08-2022"),
                        PcatId=3
                    },
                     new Packages
                    {
                        PName="Kodaikanal Vacation Package",//
                        PPrice=12000,
                        PDestination="Kodaikanal",
                        PNoofdays=4,
                        PStartdate=DateTime.Parse("01-07-2022"),
                        PEnddate=DateTime.Parse("01-08-2022"),
                        PcatId=3
                    },
                };
            }
            catch(Exception ex)
            {
                WriteLine("Error in insertion " + ex.Message);
            }
        }

        public void insertpackageddetails()
        {
            List<PackageDetails> lstdetails = new List<PackageDetails>()
            {
                new PackageDetails
                {
                    PId=101,
                    PdDescription="This is a coconut tree vacation package which is allocated in maldive",
                    PdDays=6
                },
                new PackageDetails
                {
                    PId=102,
                    PdDescription="This is a kani palm beach vacation package which is allocated in maldive",
                    PdDays=6
                },
                new PackageDetails
                {
                    PId=103,
                    PdDescription="This is a phi-phi island located in bangkok",
                    PdDays=10
                },
                new PackageDetails
                {
                    PId=104,
                    PdDescription="This is pattaya coral island located in bangkok",
                    PdDays=10
                },
                new PackageDetails
                {
                    PId=105,
                    PdDescription="This is kashmir holiday with airfare in kashmir",
                    PdDays=4
                },
                new PackageDetails
                {
                    PId=106,
                    PdDescription="This is coonor tour located in ooty",
                    PdDays=5
                },
                new PackageDetails
                {
                    PId=107,
                    PdDescription="This is Local Sight Seeing Tour Package in kulumanali",
                    PdDays=4
                },
                new PackageDetails
                {
                    PId=108,
                    PdDescription="This is Boracay Package in philliphines",
                    PdDays=4
                },
                new PackageDetails
                {
                    PId=109,
                    PdDescription="Centra Grand Beach in Thailand",
                    PdDays=4
                }
            };
        }
        //Show all categories 
        public void showallcategories()
        {
            var showcategories = (from categories in dbcontext.PackageCategory
                                  select categories).ToList<PackageCategory>();

            //printing the details of categories
            WriteLine("CategoryId\t\tCategoryName\t\tDescription");
            foreach (var item in showcategories)
            {
                WriteLine(item.PcatId + "\t" + item.PcatName + "\t" + item.PcatDescription);
            }
        }//hello

        //showing all packages under the selected category
        public void showpackages(int categoryid)
        {
            var showpackage = (from c in dbcontext.PackageCategory
                               join p in dbcontext.Packages on
                               c.PcatId equals p.PcatId
                               join d in dbcontext.PackageDetails on
                               p.PId equals d.PId
                               where c.PcatId == categoryid
                               select new
                               {
                                   categoryname = c.PcatName,
                                   packagename = p.PName,
                                   packagedescription = d.PdDescription,
                                   packageprice = p.PPrice,
                                   packagelocation = p.PDestination,
                                   packagestart = p.PStartdate,
                                   packageend = p.PEnddate,
                                   totaldays = p.PNoofdays
                               });
            WriteLine("Categoryname\t\tPackagename\t\tDescription\t\tPrice\t\tLocation\t\tStartDate\t\tEndDate\t\tTotalDays");
            foreach (var item in showpackage)
            {
                WriteLine(item.categoryname + "\t" + item.packagename + "\t" + item.packagedescription + "\t" + item.packageprice +
                    "\t" + item.packagelocation + "\t" + item.packagestart + "\t" + item.packageend + "\t" + item.totaldays);
            }

        }
    }
}
