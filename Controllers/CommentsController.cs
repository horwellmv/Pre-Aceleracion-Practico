using Microsoft.AspNetCore.Mvc;
using PreAcceleration.HorwellMurillo.Data.EfCore;
using PreAcceleration.HorwellMurillo.Entities;

namespace PreAcceleration.HorwellMurillo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : MyController<Comments, CommentsRepository>
    {
        public CommentsController(CommentsRepository repository) : base(repository)
        {

        }
    }
}
