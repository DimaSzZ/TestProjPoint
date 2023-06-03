using System;
using System.Collections.Generic;

namespace TestProjPoint.Data.Dto.PointFigure
{
    public class ResponsePointFigure
    {
        public Guid Id { get; set; }
        public double AxisX { get; set; }
        public double AxisY { get; set; }
        public string Color { get; set; }
        public double Radius { get; set; }
    }
}
