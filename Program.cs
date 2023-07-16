using System;

namespace LineComparisonProblem
{
    class Program
    {
        public static double x1, y1, x2, y2, x3, y3, x4, y4;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Problem");
            var obj =new LineComparison();
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
            //First Object
            obj.AddObject(x1,y1,x2,y2,x3,y3,x4,y4);
            //obj.AddObject(2, 3, 4, 2, 3, 5, 6, 32);
        }
    }
}
