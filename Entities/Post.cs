using System.ComponentModel.DataAnnotations;
using System;

namespace PreAcceleration.HorwellMurillo.Entities
{
    public class Post : IEntity
    {
        //Propiedades escalares de nuestras tablas/entidades.
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(40)]
        public string Title { get; set; }
        public DateTime? Date { get; set; }

        [Required]
        [StringLength(250, MinimumLength = 1)]
        public string Content { get; set; }

        [Required]
        public int UserId { get; set; }

        //Propiedades de navegacion (reference) por ser muchos Post por un usuario
        public User User { get; set; }
    }
}
