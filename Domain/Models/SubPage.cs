using System.ComponentModel.DataAnnotations;

namespace Domain.Models {
    public class SubPage {
        [Key]public string SubPageId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public User Owner { get; set; }
        public ICollection<Post> Posts { get; set; }

        public SubPage()
        {
        }
    }
}
