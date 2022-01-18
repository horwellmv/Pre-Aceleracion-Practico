using System.ComponentModel.DataAnnotations;

namespace PreAcceleration.Data
{
/*● Usuario: deberá tener,
Id.
Name
Password
Email.
Posts
Comments*/

    public class User
    {   
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }   
        public string Email { get; set; }

        public ICollection<Post> Posts { get; set; }
        public ICollection<Comments> Comments { get; set; }   

    }
}
