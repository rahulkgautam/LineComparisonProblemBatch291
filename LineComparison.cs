using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparisonProblem
{
    class LineComparison
    {
        public static void CompareTwoLineEqualOrLess()
        {
            try
            {
                double x1, y1, x2, y2, x3, y3, x4, y4;
                Console.WriteLine("Enter the (x1,y1) coordinates of the first point comma separated:");
                var x1y1 = Console.ReadLine();
                string[] xy1 = x1y1.Split(",");
                x1 = Convert.ToDouble(xy1[0]);
                y1 = Convert.ToDouble(xy1[1]);

                Console.WriteLine("Enter the (x2,y2) coordinates of the second point comma separated:");
                var x2y2 = Console.ReadLine();
                string[] xy2 = x2y2.Split(",");
                x2 = Convert.ToDouble(xy2[0]);
                y2 = Convert.ToDouble(xy2[1]);

                Console.WriteLine("Enter the (x3,y3) coordinates of the second point comma separated:");
                var x3y3 = Console.ReadLine();
                string[] xy3 = x3y3.Split(",");
                x3 = Convert.ToDouble(xy3[0]);
                y3 = Convert.ToDouble(xy3[1]);

                Console.WriteLine("Enter the (x4,y4) coordinates of the second point comma separated:");
                var x4y4 = Console.ReadLine();
                string[] xy4 = x4y4.Split(",");
                x4 = Convert.ToDouble(xy4[0]);
                y4 = Convert.ToDouble(xy4[1]);

                double length1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                double length2 = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));

                int comparisonResult = length1.CompareTo(length2);

                if (comparisonResult == 0)
                {
                    Console.WriteLine("Line 1 is equal to line 2");
                }
                else if (comparisonResult < 0)
                {
                    Console.WriteLine("Line 1 is less than line 2");
                }
                else
                {
                    Console.WriteLine("Line 1 is greater than line 2");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Please Enter only Number with comma separated");
            }
        }
    }
}
