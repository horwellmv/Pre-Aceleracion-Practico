using System.ComponentModel.DataAnnotations;

namespace PreAcceleration.Entities
{
    public class Comments
    {
        //Propiedades escalares de nuestras tablas/entidades.
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Comment { get; set; }
        public int UserId { get; set; }

        //Propiedades de navegacion (reference) por ser muchos Post por un usuario
        public User User { get; set; }
    }
}
