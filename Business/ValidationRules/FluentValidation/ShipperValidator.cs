using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ShipperValidator : AbstractValidator<Shipper>
    {
        public ShipperValidator()
        {
            RuleFor(x => x.CompanyName).NotEmpty().WithMessage("Lütfen şirket adını giriniz");
            RuleFor(x => x.Phone).NotEmpty().WithMessage("Lüfen telefon numaranızı giriniz.");
        }
    }
}
