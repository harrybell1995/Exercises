using System;
using System.Collections.Generic;

namespace Exercise_1
{
  class Program
  {
    static void Main(string[] args)
    {
      string[,] driverArray = new string[10, 5] { { "44", "HAM", "Lewis Hamilton", "MGP", "123" },
              { "18", "STR", "Lance Stroll", "AMR", "43" },
              { "11", "PER", "Sergio Perez", "RBR", "54" },
              { "7", "RAI", "Kimi Raikkonen", "ARO", "12" },
              { "16", "LEC", "Charles Leclerc", "FER", "66" },
              { "4", "NOR", "Lando Norris", "MRL", "56" },
              { "5", "VET", "Sebastian Vettel", "AMR", "87" },
              { "63", "RUS", "George Russell", "WIL", "0" },
              { "50", "SCH", "Mick Schumacher", "HAS", "2" },
              { "3", "RIC", "Daniel Ricciardo", "MRL", "45" },};

      Console.WriteLine("Input Driver Number:");
      string enteredNumber = Console.ReadLine();
      string driverName = "Not Found";

      for (int i = 0; i <= driverArray.GetUpperBound(0); i++)
      {
        if (driverArray[i, 0] == enteredNumber)
        {
          driverName = driverArray[i, 2];
        }
      }

      Console.WriteLine("Driver is: " + driverName);

    }
  }
}
