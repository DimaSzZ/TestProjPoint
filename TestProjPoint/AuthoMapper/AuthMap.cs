using AutoMapper;
using TestProjPoint.Data.Dto.Comment;
using TestProjPoint.Data.Dto.PointFigure;
using TestProjPoint.Models;

namespace TestProjPoint.AuthoMapper
{
    public class AuthMap : Profile
    {
      public AuthMap()
        {
            CreateMap<Comment, ResponseComment>();
            CreateMap<RequestComment, Comment>();
            CreateMap<PointFigure,ResponsePointFigure>();
            CreateMap<RequestPointFigure, PointFigure>();
        }
    }
}
