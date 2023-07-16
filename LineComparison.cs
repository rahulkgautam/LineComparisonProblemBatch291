using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparisonProblem
{
    public class LineComparison 
    {
        EnterInput datails = null;
        public void AddObject(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            datails = new EnterInput(x1,y1,x2,y2,x3,y3,x4,y4);
            CompareTwoLineEqualOrLess();
        }
        public void CompareTwoLineEqualOrLess()
        {
            try
            {
                var data= datails.UserInputDetails();
                double length1 = Math.Sqrt(Math.Pow(data.X2 - data.X1, 2) + Math.Pow(data.Y2 - data.Y1, 2));
                double length2 = Math.Sqrt(Math.Pow(data.X4 - data.X3, 2) + Math.Pow(data.Y4 - data.Y3, 2));

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
