using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models {
    public class Post {
        //[ForeignKey("UserId")]
        //public String UserRefId { get; set; }
        //public User user { get; set; }
        public string PostId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public User Author { get; set; }
       
        public ICollection<Post> Comments { get; set; }

        public Post()
        {
        }
    }
}
