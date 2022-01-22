using Microsoft.EntityFrameworkCore;
using PreAcceleration.HorwellMurillo.Entities;

namespace PreAcceleration.HorwellMurillo.Data
{
    public class MyDbContext : DbContext //Hereda de DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options) //Se deja asi el constructor para generar la conexion a BD
        {
        }

        //Un DbSet por cada modelo de tabla que será creada, DbSet<nombreDeLaClaseModelo> NombreQueDaráALaTablaEnSql
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comments> Comments { get; set; }
    }
}
