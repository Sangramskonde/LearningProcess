using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace LearningProcess.Models
{
       public class HomePage
    {

        [Required(ErrorMessage ="Selection Required") ]
        public String User { get; set; }

        [Required(ErrorMessage = "Username is required")]
        public String Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [MembershipPassword(
             MinRequiredNonAlphanumericCharacters = 1,
             MinNonAlphanumericCharactersError = "Your password needs to contain at least one symbol (!, @, #, etc).",
             ErrorMessage = "Your password must be 6 characters long and contain at least one symbol (!, @, #, etc)."
        )]
        [DataType(DataType.Password)]
        public String Password { get; set; }
        public int Id { get; set; }

       
    }
   
}