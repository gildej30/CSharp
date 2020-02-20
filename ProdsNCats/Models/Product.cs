using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProdsNCats.Models
{
    public class Product
    {
        [Key]
        public int ProductId {get; set;}

        [Required(ErrorMessage="Name is required.")]
        [MinLength(3, ErrorMessage="Name must be at least 3 characters.")]
        public string Name {get; set;}

        [Required(ErrorMessage="Description is required.")]
        [MaxLength(250, ErrorMessage="Too long. Description needs to be less than 250 characters.")]
        public string Description {get; set;}

        [Required(ErrorMessage="Price is required.")]
        [Range(0, Double.MaxValue)]
        public double Price {get; set;}
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;
        public List<Association> Cats {get; set;} //NAVIGATIONAL PROPERTY

    }
}