using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WedProj.Models
{
    public class Assoc
    {
        [Key]
        public int AssocId{get;set;}
        public int UId{get;set;}
        public int WId{get;set;}
        public RegUser Person{get;set;}
        public Wedding Event{get;set;}
    }
}