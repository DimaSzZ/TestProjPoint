using System;
using System.Collections.Generic;

namespace TestProjPoint.Models
{
    public class FigureBase
    {
        public Guid Id { get; set; }
        public double AxisX {get;set; }
        public double AxisY { get; set; }
        public string Color { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

    }
}
