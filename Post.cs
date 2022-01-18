using System.ComponentModel.DataAnnotations;

namespace PreAcceleration.Data
{
/*● Posts: deberá tener,

Title
Date
Content
User que creo el Post
*/

    public class Post
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; }

        public User User { get; set; }


    }
}
