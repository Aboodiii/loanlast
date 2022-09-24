using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace LoanManagementDone.Models
{
    public partial class Surety
    {
        public Surety()
        {
            Customers = new HashSet<Customer>();
        }

       


        public int SuretyId { get; set; }
        [Required(ErrorMessage = "Surety's first name is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Surety's middle name is required")]
        public string MiddleName { get; set; }
        [Required(ErrorMessage = "Surety's last name is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Surety's date of birth is required")]
        public DateTime? DateOfBirth { get; set; }
        [Required(ErrorMessage = "Surety's gender is required")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "You should at least enter one phone number")]
        [MaxLength(20), MinLength(10)]
        public string PhoneNumberOne { get; set; }
        [MaxLength(20), MinLength(10)]
        public string PhoneNumberTwo { get; set; }
        [Required(ErrorMessage = "Surety's email is required")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Surety's occupation is required")]
        public string Occupation { get; set; }

        public byte[] ProfilePicture { get; set; }
        [Required(ErrorMessage = "Surety's Id details are required")]
        public string IdType { get; set; }
        [Required(ErrorMessage = "Surety's Id details are required")]
        public string IdNumber { get; set; }
        [Required(ErrorMessage = "Surety's Id details are required")]
        public DateTime? IdIssuedDate { get; set; }
        [Required(ErrorMessage = "Surety's Id details are required")]
        public DateTime? ExpiryDate { get; set; }
        [Required(ErrorMessage = "Surety's income is required")]
        public decimal? Income { get; set; }
        public byte[] IncomeProofPhoto { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
    }
}
