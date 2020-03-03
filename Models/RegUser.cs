using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace WedProj.Models
{
    public class RegUser
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [MinLength(2)]
        public string FirstName{get;set;}

        [Required]
        [MinLength(2)]
        public string LastName{get;set;}

        [Required(ErrorMessage = "Email Field is required")]
        [EmailAddress(ErrorMessage = "Email is not valid")]
        public string Email{get;set;}

        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        
        public string Password{get;set;}

        [NotMapped]
 
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage = "The Passwords do not match")]
        public string ConfirmPass{get;set;}

        public List<Assoc> Events{get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

    }
}