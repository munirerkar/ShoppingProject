using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class SupplierValidator : AbstractValidator<Supplier>
    {
        public SupplierValidator()
        {
            RuleFor(x => x.City).NotEmpty().WithMessage("Lütfen bulunduğunuz şehiri giriniz.");
            RuleFor(x => x.Address).NotEmpty().WithMessage("Lütfen adresinizi giriniz.");
            RuleFor(x => x.CompanyName).NotEmpty().WithMessage("Lütfen şirket isminizi giriniz.");
            RuleFor(x => x.Country).NotEmpty().WithMessage("Lütfen bulunduğunuz ülkeyi giriniz");
        }
    }
}
