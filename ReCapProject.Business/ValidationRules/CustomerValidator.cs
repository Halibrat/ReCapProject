using FluentValidation;
using ReCapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.Business.ValidationRules
{
   public class CustomerValidator:AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(cu => cu.Id).NotEmpty();
            RuleFor(cu => cu.CompanyName).NotEmpty();
        }
    }
}
