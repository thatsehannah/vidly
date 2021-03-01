﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly_V2.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            if (customer.MembershipTypeId == 0|| customer.MembershipTypeId == 1)
            {
                return ValidationResult.Success; //use static field for successful validation result
            } 

            if (customer.Birthday == null)
            {
                return new ValidationResult("Birthday is required"); //to indicate an error, instantiate a new validation result
            }

            var age = DateTime.Today.Year - customer.Birthday.Value.Year;

            return (age >= 18) 
                ? ValidationResult.Success 
                : new ValidationResult("Customer should be at least 18 years old to go on a Membership");
        }
    }
}