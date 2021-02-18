using System;
using System.Collections.Generic;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] driverArray = new string[10, 5] { { "44", "HAM", "Lewis Hamilton", "MGP", "123" }, //create new 2d array
              { "18", "STR", "Lance Stroll", "AMR", "43" },
              { "11", "PER", "Sergio Perez", "RBR", "54" },
              { "7", "RAI", "Kimi Raikkonen", "ARO", "12" },
              { "16", "LEC", "Charles Leclerc", "FER", "66" },
              { "4", "NOR", "Lando Norris", "MRL", "56" },
              { "5", "VET", "Sebastian Vettel", "AMR", "87" },
              { "63", "RUS", "George Russell", "WIL", "0" },
              { "50", "SCH", "Mick Schumacher", "HAS", "2" },
              { "3", "RIC", "Daniel Ricciardo", "MRL", "45" },};

            for (int i = 0; i <= driverArray.GetUpperBound(0); i++)
            {
                Console.WriteLine(driverArray[i, 2]); //write array to console           
            }
        }
    }
}
