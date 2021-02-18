using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_3
{

    public class Driver
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
            List<Driver> DriverList = new List<Driver>();    
            List<Driver> OrderedStandings = new List<Driver>();
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

            string userName = Console.ReadLine();

            try
            {
              var numbers = userName.Split(',').Select(Int32.Parse).ToList();
              int ListLocation = DriverList.FindIndex(x => x.DriverNumber == numbers[0]);
              DriverList[ListLocation].DriverPoints = DriverList[ListLocation].DriverPoints + numbers[1];
            }
            catch
            {
              Console.WriteLine("Number not found, posting ordered list without changes");
            }

            OrderedStandings = DriverList.OrderByDescending(x => x.DriverPoints).ToList();
            foreach (var item in OrderedStandings)
            {
              Console.WriteLine(item.DriverAbrv + "\t" + item.DriverPoints);
            }
        }
    }
} 

