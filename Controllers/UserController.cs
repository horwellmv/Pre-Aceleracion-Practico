using Microsoft.AspNetCore.Mvc;
using PreAcceleration.HorwellMurillo.Data.EfCore;
using PreAcceleration.HorwellMurillo.Entities;
using PreAcceleration.HorwellMurillo.Controllers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PreAcceleration.HorwellMurillo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : MyController<User, UserRepository>
    {
        public UserController(UserRepository repository) : base(repository)
        {

        }
    }
}
