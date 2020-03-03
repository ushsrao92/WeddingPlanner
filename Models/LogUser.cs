using System.ComponentModel.DataAnnotations;
using System;
namespace WedProj.Models
{
    public class LogUser
    {
        [Required(ErrorMessage = "Email Address is Required")]
        [EmailAddress(ErrorMessage = "Email Address is not valid")]
        [Display(Name = "Email")]
        public string LogEmail{get;set;}

        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        
        public string LogPassword{get;set;}

    }
}