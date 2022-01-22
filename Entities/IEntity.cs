using System.ComponentModel.DataAnnotations;

namespace PreAcceleration.HorwellMurillo.Entities
{
    public interface IEntity //De esta interface heredamos todos nuestros DataModels
    {
        [Key]
        int Id { get; set; }
    }
}
