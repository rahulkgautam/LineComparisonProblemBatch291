using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparisonProblem
{
    class LineComparison
    {
        public static void ISTwoLineEqual()
        {
            try
            {
                double x1, y1, x2, y2;

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

                double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

                Console.WriteLine($"The length of the line connecting ({x1},{y1}) and ({x2},{y2}) is {length}");
                if ((x1 == y1 && y2 == x2) || (x1 == x2 && y1 == y2))
                {
                    Console.WriteLine("The two lines are equal.");
                }
                else
                {
                    Console.WriteLine("The two lines are not equal.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Please Enter only Number with comma separated");
            }
        }
    }
}
