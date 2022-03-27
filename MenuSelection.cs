using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Convert;
namespace Travel_And_Tourism_Project
{
    public class MenuSelection
    {
        public MenuSelection()
        {
            bool flag = true;
            while (flag)
            {
                WriteLine("Please Select the Menu Details");
                WriteLine("1.Show Package categories");
                WriteLine("2.Insert Package Selection");
                WriteLine("3.Update Package Selection");
                WriteLine("4.Delete Package Selection");
                WriteLine("5.Proceed to Payment");
                WriteLine("6.Show Booking Details");
                int choice;
                bool state=int.TryParse(Console.ReadLine(), out choice);
                while (!state)
                {
                    WriteLine("Wrong input.Try Again!");
                    state=int.TryParse(Console.ReadLine(), out choice);
                }

                switch (choice)
                {
                    case 1:
                        new PackageAllDetails();
                        break;
                }
            }
        }
    }
}
