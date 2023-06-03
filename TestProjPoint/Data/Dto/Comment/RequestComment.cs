using System;

namespace TestProjPoint.Data.Dto.Comment
{
    public class RequestComment
    {
        public string Text { get; set; }

        public string ColorText { get; set; }
        public string BackGroundColor { get; set; }

        public Guid FigureBaseId { get; set; }
    }
}
