using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TestProjPoint.Application.Interface;
using TestProjPoint.Data.DbContext;
using TestProjPoint.Data.Dto.PointFigure;
using TestProjPoint.Models;

namespace TestProjPoint.Application.Repositories
{
    public class PointRepository : IPoint
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        public PointRepository(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<string> DeletePoint(Guid id, CancellationToken cancellationToken)
        {
            var pointFigure = await _context.PointFigure.FindAsync(id);
            if (pointFigure == null)
                throw new Exception("Not found");
            _context.PointFigure.Remove(pointFigure);
            await _context.SaveChangesAsync(cancellationToken);
            return "Point has been deleted";
        }

        public async Task<List<ResponsePointFigure>> GetAllPoints(CancellationToken cancellationToken)
        {
            var points = await _context.PointFigure.ToListAsync(cancellationToken);
            var responsePoints = _mapper.Map<List<ResponsePointFigure>>(points);
            return responsePoints;
        }

        public async Task<ResponsePointFigure> GetPoint(Guid Id, CancellationToken cancellationToken)
        {
            var point = await _context.PointFigure.FindAsync(Id);
            var responsPoint = _mapper.Map<ResponsePointFigure>(point);
            return responsPoint;
        }

        public async Task SavePointFigure(RequestPointFigure request, CancellationToken cancellationToken)
        {
            var data = _mapper.Map<PointFigure>(request);
            if (_context.PointFigure.Contains(data))
            {
                _context.Update(data);
            }
            else
                await _context.PointFigure.AddAsync(data, cancellationToken);

            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
