using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankAccounts.Models
{
    public class User
    {
        [Key]
        public int UserId {get;set;}

        [Required(ErrorMessage="First Name is required.")]
        [Display(Name="First Name: ")]
        [MinLength(3, ErrorMessage="First name must be at least 3 characters.")]
        public string FirstName {get;set;}

        [Required(ErrorMessage="Last Name is required.")]
        [Display(Name="Last Name: ")]
        [MinLength(3, ErrorMessage="Last name must be at least 3 characters.")]
        public string LastName {get;set;}

        [EmailAddress]
        [Required(ErrorMessage="Email is required.")]
        [Display(Name="Email: ")]
        public string Email {get;set;}

        [DataType(DataType.Password)]
        [Required(ErrorMessage="Password is required.")]
        [Display(Name="Password: ")]
        [MinLength(8, ErrorMessage="Passwords must be at least 8 characters long.")]
        public string Password {get;set;}

        [Required(ErrorMessage="Confirm password is required.")]
        [Display(Name="Confirm Password: ")]
        [Compare("Password")]
        [DataType(DataType.Password)]
        [NotMapped]
        public string ConfirmPassword {get; set;}
        public List<Transaction> MyTransactions {get; set;} //NAVIGATIONAL PROPERTY
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}