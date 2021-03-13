using FluentValidation;
using ReCapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.Business.ValidationRules
{
   public class ColorValidator:AbstractValidator<Color>
    {
        public ColorValidator()
        {
            
            RuleFor(co => co.Id).NotEmpty();
            RuleFor(co => co.ColorName).NotEmpty();
        }
    }
}
