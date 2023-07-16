using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparisonProblem
{
   public class EnterInput
    {
        public double x1, y1, x2, y2, x3, y3, x4, y4;
        public EnterInput(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.x3 = x3;
            this.x4 = x4;
            this.y1 = y1;
            this.y2 = y2;
            this.y3 = y3;
            this.y4 = y4;
        }
        public LineComparisonModel UserInputDetails()
        {
            var lineCoparisoModel = new LineComparisonModel();
            lineCoparisoModel.X1 = x1;
            lineCoparisoModel.Y1 = y1;
            lineCoparisoModel.X2 = x2;
            lineCoparisoModel.Y2 = y2;
            lineCoparisoModel.X3 = x3;
            lineCoparisoModel.Y3 = y3;
            lineCoparisoModel.X4 = x4;
            lineCoparisoModel.Y4 = y4;
            return lineCoparisoModel;
        }
    }
}
