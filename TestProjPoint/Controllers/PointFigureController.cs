using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;
using System.Threading.Tasks;
using TestProjPoint.Application.Interface;
using TestProjPoint.Data.Dto.PointFigure;

namespace TestProjPoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PointFigureController : ControllerBase
    {
        private readonly IPoint _point;
        public PointFigureController(IPoint point)
        {
            _point = point;
        }
        [HttpPost("SavePoint")]
        public async Task<IActionResult> SavePoint(RequestPointFigure request, CancellationToken cancellationToken)
        {
            await _point.SavePointFigure(request,cancellationToken);
            return Ok("Point has been saved");
        }
        [HttpGet("GetPoint")]
        public async Task<IActionResult> GetPoint([FromQuery] Guid id, CancellationToken cancellationToken)
        {
            var response = await _point.GetPoint(id, cancellationToken);
            return Ok(response);
        }
        [HttpGet("GetAllPoints")]
        public async Task<IActionResult> GetAllPoints(CancellationToken cancellationToken)
        {
            var response = await _point.GetAllPoints(cancellationToken);
            return Ok(response);
        }
        [HttpDelete("DeletePoint")]
        public async Task<IActionResult> DeletePoint(Guid id, CancellationToken cancellationToken)
        {
            await _point.DeletePoint(id, cancellationToken);
            return Ok("Point has been saved");
        }
    }
}
