﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models {
    public class SubPage {
        
        [Key]public string SubPageId { get; set; }
       // [ForeignKey("UserId")]
        //public String UserRefId { get; set; }
        //public User user { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public User Owner { get; set; }
        public ICollection<Post> Posts { get; set; }


  

        public SubPage()
        {
        }
    }
    
    
}
