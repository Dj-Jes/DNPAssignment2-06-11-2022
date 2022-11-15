using System.ComponentModel.DataAnnotations;

namespace Domain.Models {
    public class User {
         [Key]
         public string UserId { get; set; }
        public string Username { get; set; }
        public string HashedPassword { get; set; }
     
        public ICollection<SubPage> SubscribedSubs { get; set; }

        

        public User()
        {
        }

       
    }

    
}
