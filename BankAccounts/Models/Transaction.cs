using System;
using System.ComponentModel.DataAnnotations;

namespace BankAccounts.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId {get; set;}

        [Display(Name="Deposit/Withdraw: ")]
        [Required(ErrorMessage="Must enter in an amount.")]
        public double Amount {get; set;}

        public int UserId {get; set;} //FOREGIN KEY

        public User AccountHolder {get; set;} //NAVIGATIONAL PROPERTY

        public DateTime CreatedAt {get;set;} = DateTime.Now;

        public DateTime UpdatedAt {get; set;} = DateTime.Now;
    }
}