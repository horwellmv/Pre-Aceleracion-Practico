using System.ComponentModel.DataAnnotations;

namespace PreAcceleration.Entities

{
    public class User
    {
        //Propiedades escalares de nuestras tablas/entidades.
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        //Propiedades de navegacion (Collection) Por ser uno a muchos o muchos a muchos.
        public ICollection<Post> Posts { get; set; }
        public ICollection<Comments> Comments { get; set; }

    }
}
