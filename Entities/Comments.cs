using System;
using System.ComponentModel.DataAnnotations;

namespace PreAcceleration.HorwellMurillo.Entities
{
    public class Comments : IEntity
    {
        //Propiedades escalares de nuestras tablas/entidades.
        [Key]
        public int Id { get; set; }
        public DateTime? Date { get; set; }

        [Required]
        [StringLength(250)]
        public string Comment { get; set; }

        [Required]
        public int UserId { get; set; }

        //Propiedades de navegacion (reference) por ser muchos Post por un usuario
        public User User { get; set; }
    }
}
