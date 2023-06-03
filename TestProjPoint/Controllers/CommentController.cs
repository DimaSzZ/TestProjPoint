using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TestProjPoint.Application.Interface;
using TestProjPoint.Data.Dto.Comment;

namespace TestProjPoint.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly IComment _comment;

        public CommentController(IComment comment)
        {
            _comment = comment;
        }
        [HttpGet("GetCommentsById")]
        public async Task<IActionResult> GetCommentsById([FromQuery] Guid id,CancellationToken cancalationToken)
        {
            var comments = await _comment.GetCommentsById(id, cancalationToken);
            return Ok(comments);
        }
        [HttpPost("SaveComments")]
        public async Task<IActionResult> SaveComments(Guid id,List<RequestComment> comments,CancellationToken cancellationToken)
        {
            var responseComments = await _comment.SaveComments(id,comments,cancellationToken);
            return Ok(responseComments);
        }
    }
}
