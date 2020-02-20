using System.ComponentModel.DataAnnotations;
using System;

namespace CRUDelicious.Models
{
    public class Dish
    {
        public int DishID {get;set;}
        [Required(ErrorMessage="Name is too short")]
        [MinLength(3, ErrorMessage="The dish name needs to be at least 3 characters long.")]
        public string Name {get;set;}
        
        [Required(ErrorMessage="Chef name is too short.")]
        [MinLength(3, ErrorMessage="The chef name needs to be at least 3 characters long.")]
        public string Chef {get;set;}
        [Required(ErrorMessage="Tastiness is required.")]
        public int Tastiness {get;set;}
        
        [Required(ErrorMessage="Calorie about is required.")]
        public int Calories {get;set;}
        [Required(ErrorMessage="A DISH-cription is required.")]
        [MinLength(15, ErrorMessage="The DISH-cription needs to be at least 15 characters.")]
        public string Description {get;set;}
        public DateTime CreatedAt {get;set;}
        public DateTime UpdatedAt {get;set;}
    }
}