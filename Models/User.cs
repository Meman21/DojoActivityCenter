using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DojoActivityCenter.Models
{
    public class User: BaseEntity
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int UserId {get; set;}

        public string fname {get; set;}

        public string lname {get; set;}

        public string email {get; set;}
     
        public string password {get; set;}

        public List<UserActivity> UserActivity {get; set;}

        public User()
        {
            UserActivity = new List<UserActivity>();
        }
       
    }
}