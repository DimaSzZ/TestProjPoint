using System;

namespace TestProjPoint.Models
{
    public class Comment
    {
        public Guid Id { get; set; }
        public string Text { get; set; }

        public string ColorText { get; set; }
        public string BackGroundColor { get; set; } 

        public Guid FigureBaseId { get; set; }
        public FigureBase FigureBase { get; set; }
    }
}
