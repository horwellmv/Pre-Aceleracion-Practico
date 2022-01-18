using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using PreAcceleration.Entities;


namespace PreAcceleration.UI
{
    internal class MyDbContext : DbContext
    {
        //Configuracion inicial Opcional de nombre, servidor y tipo de logeo en la Base de datos.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=DbPreAcceleration;Trusted_Connection=True;");
        }

        //Mis Entidades
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comments> Comments { get; set; }

    }

}

// Debemos tener Instalados los Nugets 
// Microsoft.EntityFrameworkCore
// Microsoft.EntityFrameworkCore.Design
// Microsoft.EntityFrameworkCore.SqlServer
// Microsoft.EntityFrameworkCore.Tools

// Ahora en Tools/Nuget Package Manager/Package Manager Console/ Escribimos los siguientes comandos
// Add-Migration Initial
// Update-Database
// Ahora nuestra Db estará creada con nuestras clases como tablas.