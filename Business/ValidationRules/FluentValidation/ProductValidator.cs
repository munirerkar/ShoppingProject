using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<ProductAddDto>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).MinimumLength(2).WithMessage("2 karekterden az olamaz");
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.ProductDescription).MinimumLength(200).WithMessage("200 karekterden az olamaz");
            RuleFor(p => p.ProductDescription).NotEmpty();
            RuleFor(p => p.BarcodeNumber).MinimumLength(12).MaximumLength(12);
            RuleFor(p => p.BarcodeNumber).NotEmpty();
        }
    }
}
