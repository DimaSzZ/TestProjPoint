using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using TestProjPoint.Data.Dto.Comment;

namespace TestProjPoint.Application.Interface
{
    public interface IComment
    {
        public Task<List<ResponseComment>> SaveComments(Guid idPointFigure, List<RequestComment> comments, CancellationToken cancellation);

        public Task<List<ResponseComment>> GetCommentsById(Guid idPointFigure,CancellationToken cancellation);
    }
}
