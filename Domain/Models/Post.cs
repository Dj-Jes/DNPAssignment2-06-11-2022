using System.ComponentModel.DataAnnotations;

namespace Domain.Models {
    public class Post {
        [Key]public string PostId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public User Author { get; set; }
        public ICollection<Post> Comments { get; set; }

        public Post()
        {
        }
    }
}
