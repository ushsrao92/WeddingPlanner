using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace WedProj.Models
{
    public class Wedding
    {
        [Key]
        public int WedId {get;set;}

        [Required]
        [MinLength(2)]
        public string Wedder_One{get;set;}

        [Required]
        [MinLength(2)]
        public string Wedder_Two{get;set;}

        [Required]
        public DateTime WeddingDate{get;set;}

        [Required]
        public string WeddingAddress{get;set;}

        public int? CreatorId {get;set;}



        public List<Assoc> Guests{get;set;} = new List<Assoc>();
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

    }
}