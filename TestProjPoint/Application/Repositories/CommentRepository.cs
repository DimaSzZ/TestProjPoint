using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TestProjPoint.Application.Interface;
using TestProjPoint.Data.DbContext;
using TestProjPoint.Data.Dto.Comment;
using TestProjPoint.Models;

namespace TestProjPoint.Application.Repositories
{
    public class CommentRepository : IComment
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public CommentRepository(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<ResponseComment>> GetCommentsById(Guid idPointFigure, CancellationToken cancellation)
        {
            var comments = await _context.Comments.Where(com => com.FigureBaseId == idPointFigure).ToListAsync(cancellation);
            var commentResponse = _mapper.Map<List<ResponseComment>>(comments);
            return commentResponse;
        }


        public async Task<List<ResponseComment>> SaveComments(Guid idPointFigure, List<RequestComment> comments, CancellationToken cancellation)
        {
            var point = await _context.PointFigure.FindAsync(idPointFigure);
            var commentsModel = _mapper.Map<List<Comment>>(comments);
            if (point == null)
            {
                throw new Exception("Point doesn't exist");
            }

            var existingComments = _context.Comments.Where(c => c.FigureBaseId == idPointFigure);
            _context.Comments.RemoveRange(existingComments);

            point.Comments = commentsModel;

            _context.Update(point);
            await _context.SaveChangesAsync(cancellation);
            return _mapper.Map<List<ResponseComment>>(point.Comments);
        }


    }
}
