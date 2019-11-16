using Microsoft.AspNetCore.Mvc;
using project1_milestone.Custom_Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace project1_milestone.Models.User
{
    public class User : IValidatableObject
    {

        [Display(Name = "Id")]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "The Name field is required!")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The Surname field is required!")]
        [Display(Name = "Surname")]
        public string Surname { get; set; }

        [Display(Name = "Middlename")]
        public string Middlename { get; set; }

        [Required(ErrorMessage = "The IDN field is required!")]
        [StringLength(12), MinLength(12)]
        [IDNValidation]
        [Display(Name = "IDN")]
        public string IDN { get; set; }

        [Required(ErrorMessage = "The Phone field is required!")]
        [Remote(action: "VerifyForExistence", controller: "Users")]
        [Display(Name = "Phone")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "The Email field is required!")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "The Nationality field is required!")]
        [Display(Name = "Nationality")]
        public string Nationality { get; set; }

        [Required(ErrorMessage = "The Birthday field is required!")]
        [Display(Name = "Birthday")]
        public DateTime Birthday { get; set; }

        [Required(ErrorMessage = "The Password field is required!")]
        [MinLength(8, ErrorMessage = "The length of password should be minimum 8 symbols!")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (!Phone.Contains("+7"))
            {
                yield return new ValidationResult("Phone doesn't contain code +7!");
            } 
        }
    }
}
