using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace PreAcceleration.HorwellMurillo.Entities
{
    public class User : IEntity
    {
        //Propiedades escalares de nuestras tablas/entidades.
        [Key]
        public int Id { get; set; }

        [StringLength(40)]
        [Required]
        public string Name { get; set; }

        [StringLength(10, MinimumLength = 4)]
        [Required]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        //Propiedades de navegacion (Collection) Por ser uno a muchos o muchos a muchos.
        public ICollection<Post> Posts { get; set; }
        public ICollection<Comments> Comments { get; set; }
    }
}
