using FluentValidation;
using ReCapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.Business.ValidationRules
{
   public class CarImageValidator:AbstractValidator<CarImage>
    {
         public CarImageValidator()
        {
            RuleFor(ci => ci.Id).NotEmpty();
            RuleFor(ci => ci.CarId).NotEmpty();
            RuleFor(ci => ci.ImagePath).MaximumLength(5);
            RuleFor(ci => ci.Date).NotEmpty();
        }
    }
}
