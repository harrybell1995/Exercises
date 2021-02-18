using System;
using System.Collections.Generic;
using System.Linq;


namespace Exercise_4
{
  class Program
    {
      static bool HaveSegmentOverlap(int s1, int s2, int s3, int s4) //method mentioned in breif
        {
            bool doesOverlap; //create the bool that we return
            double range = Math.Max(0, Math.Min(s2, s4) - Math.Max(s1, s3) + 1);  //range is the amount of integers that are found in both ranges
                
            //takes max lower bound from s2 & s4 and min upper bounds from s1 & s3.
            //the range comes from subtracting the upper and lower bounds 
            //if the range is negative then just set the range to 0 which is used below
        
            //eg math.min(10, 20) - math.max (2, 5) would result in there being an overlap of 6. this comes from the max number being 5 and the min being 10.
            //numbers 5,6,7,8,9,10 would be in the overlapping range (in both sets of numbers)
        
            Console.WriteLine(range);
            if (range > 0)//if calculated number is more than 0 then there is an overlap
            {
                doesOverlap = true;
            }
            else//otherwise no overlap
            {
                doesOverlap = false;
            }
                return doesOverlap;//returns the bool
            }

    static void Main(string[] args)
        {
            string InputNumbers = Console.ReadLine(); //read user input
            var numbers = InputNumbers.Split(',').Select(Int32.Parse).ToList(); //split to list like in excersie 3 based on comma
            bool overlapResult = HaveSegmentOverlap(numbers[0], numbers[1], numbers[2], numbers[3]); //send each list item to above method
            Console.WriteLine(overlapResult); //write returned bool value to console
    }
  }
}
