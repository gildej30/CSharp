using System;
using System.ComponentModel.DataAnnotations;

namespace ChefsNDishes.Models
{
    public class Dish
    {
        [Key]
        public int DishID {get;set;}

        [Required(ErrorMessage="Dish name is required.")]
        [MinLength(3,ErrorMessage="Dish must be at least 3 characters.")]
        public string Name {get;set;}
        
        [Required]
        [Range(1,5, ErrorMessage="Tastiness needs to be between 1 and 5.")]
        public int Tastiness {get;set;}
        [Required]
        [Range(0, Int32.MaxValue, ErrorMessage="Tastiness needs to be more that 0.")]
        public int Calories {get;set;}
        
        [Required(ErrorMessage="Description is required.")]
        [MaxLength(250, ErrorMessage="Too long. Descriptions need to be less that 250 characters.")]
        public string Description {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
        public int ChefId {get;set;} //FOREIGN KEY
        public Chef Creator {get;set;}
    }
}