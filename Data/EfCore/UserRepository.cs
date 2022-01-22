using PreAcceleration.HorwellMurillo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PreAcceleration.HorwellMurillo.Data.EfCore
{
    public class UserRepository : EfCoreRepository<User, MyDbContext>
    {
        public UserRepository(MyDbContext context) : base(context)
        {

        }
        // We can add new methods specific to the movie repository here in the future
    }
}

