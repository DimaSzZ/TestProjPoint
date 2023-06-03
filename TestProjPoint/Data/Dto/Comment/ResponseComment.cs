using System;

namespace TestProjPoint.Data.Dto.Comment
{
    public class ResponseComment
    {
        public Guid Id { get; set; }
        public string Text { get; set; }

        public string ColorText { get; set; }

        public string BackGroundColor { get; set; }

        public Guid FigureBaseId { get; set; }
    }
}
