using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WeddingPlanner.Models
{
    public class Wedding
    {
        public int WeddingId {get; set;}
        
        [Required(ErrorMessage="WedderOne is required.")]
        [Display(Name="Wedder One: ")]
        public string WedderOne {get;set;}

        [Required(ErrorMessage="WedderTwo is required.")]
        [Display(Name="Wedder Two: ")]
        public string WedderTwo {get; set;}

        [Required(ErrorMessage="Wedding date is required.")]
        [Display(Name="Wedding Date:")]
        [FutureDate]
        public DateTime Date {get;set;} = DateTime.Now;

        [Required(ErrorMessage="Address is required.")]
        [Display(Name="Address:")]
        public string Address {get;set;}

        public int UserId {get;set;} //FOREIGN KEY

        public User Planner {get;set;} // NAVIGATIONAL PROPERTY // a wedding can only have one planner - ONE to MANY
        public List<RSVP> GuestList {get;set;} //a wedding have have many guests MANY to MANY
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

    }

    public class FutureDateAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime check;
            if(value is DateTime)
            {
                check = (DateTime)value;
                if(check < DateTime.Now)
                {
                    return new ValidationResult("Date must be in the future.");
                }
                else
                {
                    return ValidationResult.Success;
                }
            }
            else
            {
                return new ValidationResult("DateTime is invalid.");
            }
        }
    }
}