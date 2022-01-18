using System.ComponentModel.DataAnnotations;

namespace PreAcceleration.Entities
{
    public class Post
    {
        //Propiedades escalares de nuestras tablas/entidades.
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; }

        //Propiedades de navegacion (reference) por ser muchos Post por un usuario
        public User User { get; set; }

    }
}
