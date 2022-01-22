using PreAcceleration.HorwellMurillo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PreAcceleration.HorwellMurillo.Data.EfCore
{
    public class PostRepository : EfCoreRepository<Post, MyDbContext>
    {
        public PostRepository(MyDbContext context) : base(context)
        {

        }
        // We can add new methods specific to the movie repository here in the future
    }
}

