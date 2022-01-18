using System.ComponentModel.DataAnnotations;

namespace PreAcceleration.Data
{
/*● Comments: deberá tener,

Id.
Date
Comment
User que creo el Comment
*/

    public class Comments
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Comment { get; set; }
        public int UserId { get; set; }

        public User User { get; set; }

    }
}
