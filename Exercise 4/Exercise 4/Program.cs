using System;
using System.Collections.Generic;
using System.Linq;


namespace Exercise_4
{
  class Program
    {
      static bool HaveSegmentOverlap(int s1, int s2, int s3, int s4)
        {
        bool doesOverlap;
            double range = Math.Max(0, Math.Min(s2, s4) - Math.Max(s1, s3) + 1);  
            Console.WriteLine(range);
            if (range > 0)
            {
                doesOverlap = true;
            }
            else
            {
                doesOverlap = false;
            }
                return doesOverlap;
            }

    static void Main(string[] args)
        {
            string InputNumbers = Console.ReadLine();
            var numbers = InputNumbers.Split(',').Select(Int32.Parse).ToList();
            bool overlapResult = HaveSegmentOverlap(numbers[0], numbers[1], numbers[2], numbers[3]);
            Console.WriteLine(overlapResult);
    }
  }
}
