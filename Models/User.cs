#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace FormSubmission.Models;

public class User
    {   
        [Display(Name="First Name:")]
        [Required]
        [MinLength(4, ErrorMessage="First name must be at least 4 characters")]
        public string FirstName { get; set; } 
        [Display(Name="Last Name:")]
        [Required]
        [MinLength(4, ErrorMessage="Last name must be at least 4 characters")]
        public string LastName { get; set; }
        [Required]
        [Range(0, Int32.MaxValue, ErrorMessage="Age must be a positive number")]
        public int Age { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage="Password must be at least 8 characters")]
        public string Password { get; set; }


    }