using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace project1_milestone.Custom_Validation
{
    public class IDNValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string idn = value.ToString();
            /*if (idn.Contains('0'))
            {
                return new ValidationResult(GetErrorMessage());
            }*/
            bool right = true;
            foreach (char c in idn)
            {
                if ((int)c < (int)'0' || (int)c > (int)'9')
                {
                    right = false;
                    break;
                }
            }
            return right ? ValidationResult.Success : new ValidationResult(GetErrorMessage());
        }

        public string GetErrorMessage()
        {
            return "The IDN mustn't contain any letters. only numbers!";
        }
    }
}
