using Microsoft.AspNetCore.Mvc;
using PreAcceleration.HorwellMurillo.Data.EfCore;
using PreAcceleration.HorwellMurillo.Entities;

namespace PreAcceleration.HorwellMurillo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : MyController<Post, PostRepository>
    {
        public PostController(PostRepository repository) : base(repository)
        {

        }
    }
}
