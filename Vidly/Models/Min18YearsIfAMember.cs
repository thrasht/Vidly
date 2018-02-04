using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            if (customer.MembershipTypeId == MembershipType.Unknown || customer.MembershipTypeId == MembershipType.PayAsYouGo)
                return ValidationResult.Success;

            if(customer.DateOfBirthday == null)
                return new ValidationResult("Birthday is Required");

            var age = DateTime.Today.Year - customer.DateOfBirthday.Value.Year;

            return (age > 18) 
                ? ValidationResult.Success 
                : new ValidationResult("El customer tiene que tener al menos 18 para una membresía");
        }
    }
}