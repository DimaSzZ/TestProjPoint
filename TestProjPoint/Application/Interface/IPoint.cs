using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using TestProjPoint.Data.Dto.PointFigure;
using TestProjPoint.Models;

namespace TestProjPoint.Application.Interface
{
    public interface IPoint
    {
        public Task SavePointFigure(RequestPointFigure request,CancellationToken cancellationToken);
        public Task<List<ResponsePointFigure>> GetAllPoints(CancellationToken cancellationToken);

        public Task<ResponsePointFigure> GetPoint(Guid Id,CancellationToken cancellationToken);
        public Task<string> DeletePoint(Guid id,CancellationToken cancellationToken);
    }
}
