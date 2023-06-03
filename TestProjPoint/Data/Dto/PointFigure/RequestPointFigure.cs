using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestProjPoint.Data.Dto.PointFigure
{
    public class RequestPointFigure
    {
        public double AxisX { get; set; }
        public double AxisY { get; set; }
        public string Color { get; set; }
        public double Radius { get; set; }
    }
}
