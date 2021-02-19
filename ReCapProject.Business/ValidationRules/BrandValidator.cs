using FluentValidation;
using ReCapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.Business.ValidationRules
{
   public class BrandValidator:AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(b => b.Id).NotEmpty();
            RuleFor(b => b.BrandName).NotEmpty();
        }
    }
}
