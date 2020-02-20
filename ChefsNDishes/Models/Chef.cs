using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ChefsNDishes.Models
{
    public class Chef
    {
        [Key]
        public int ChefId {get;set;} //KEY FOR DISH MODEL

        [Required(ErrorMessage="First name is required.")]
        [Display(Name="First Name: ")]
        [MinLength(3,ErrorMessage="First name must be at least 3 characters.")]

        public string FirstName {get;set;}

        [Required(ErrorMessage="Last name is required.")]
        [Display(Name="Last Name: ")]
        [MinLength(3,ErrorMessage="Last name must be at least 3 characters.")]
        public string LastName {get;set;}

        [Required(ErrorMessage="Birthday is required.")]
        [Display(Name="Birthday: ")]
        [DataType(DataType.Date)]
        public DateTime Birthday {get;set;}

        public int Age()
        {
            int age = DateTime.Now.Year - Birthday.Year;
            return age;
        }

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;}= DateTime.Now;
        public List<Dish> ChefDishes {get;set;} //NAVIGATIONAL PROPERTY
    }
}