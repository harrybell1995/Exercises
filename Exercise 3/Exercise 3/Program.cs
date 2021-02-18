using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_3
{

    public class Driver //driver class, used this instead of a array as we need to search by ints and cant create mixed variable arrays (also wanted to show that i can actually code in better quality)
    {
        public string DriverName;
        public string DriverAbrv;
        public string DriverTeam;
        public int DriverPoints;
        public int DriverNumber;
        public Driver(int number, string abrv, string name, string team, int points)
            {
                DriverName = name;
                DriverAbrv = abrv;
                DriverPoints = points;
                DriverNumber = number;
                DriverTeam = team;
    }
  }

    class Program
    {
        static void Main(string[] args)
        {
            List<Driver> DriverList = new List<Driver>();    //i chose this as the way to create new driver objs because its the quickest way. it would take a few mins to get this to read 
            List<Driver> OrderedStandings = new List<Driver>();  //from file but going strictly from the brief we were given, it was not a needed feature.
            DriverList.Add(new Driver(44, "HAM", "Lewis Hamilton", "MGP", 123));
            DriverList.Add(new Driver(18, "STR", "Lance Stroll", "AMR", 43));
            DriverList.Add(new Driver(11, "PER", "Sergio Perez", "RBR", 54));
            DriverList.Add(new Driver(7, "RAI", "Kimi Raikkonen", "ARO", 12));
            DriverList.Add(new Driver(16, "LEC", "Charles Leclerc", "FER", 66));
            DriverList.Add(new Driver(4, "NOR", "Lando Norris", "MRL", 56));
            DriverList.Add(new Driver(5, "VET", "Sebastian Vettel", "AMR", 87));
            DriverList.Add(new Driver(63, "RUS", "George Russell", "WIL", 0));
            DriverList.Add(new Driver(50, "SCH", "Mick Schumacher", "HAS", 2));
            DriverList.Add(new Driver(3, "RIC", "Daniel Ricciardo", "MRL", 45));



      Console.WriteLine("Enter driver number & points gained");

            string userName = Console.ReadLine(); //reads user input

            try
            {
              var numbers = userName.Split(',').Select(Int32.Parse).ToList(); //split input based on comma into list (creates 2 list items)
              int ListLocation = DriverList.FindIndex(x => x.DriverNumber == numbers[0]); //searches list for obj.drivernumber that matchest first list value
              DriverList[ListLocation].DriverPoints = DriverList[ListLocation].DriverPoints + numbers[1]; //adds number to driverpoints in location of listlocation
            }
            catch //incase the input is not as expected
            {
              Console.WriteLine("Number not found, posting ordered list without changes");
            }

            OrderedStandings = DriverList.OrderByDescending(x => x.DriverPoints).ToList(); //makes a second list thats ordered desc, the original should be deleted for memory reasons but didnt see the need on such a small program
            foreach (var item in OrderedStandings) //for all items in list write out the TLA & their points as required in breif
            {
              Console.WriteLine(item.DriverAbrv + "\t" + item.DriverPoints);
            }
        }
    }
} 

