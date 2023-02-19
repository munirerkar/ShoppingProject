using Entities.Concrete;
using Entities.DTOs.Customer;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<CustomerDto>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.TcNo).MinimumLength(11).MaximumLength(11).WithMessage("Tc numaranız 11 haneli olmalıdır");
            RuleFor(x => x.TcNo).NotEmpty();
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("Lütfen adınızı giriniz.");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Lütfen soyadınızı giriniz.");
            RuleFor(x => x.Phone).NotEmpty().WithMessage("Lütfen telefon numaranızı  giriniz.");
            RuleFor(x => x.Phone).MinimumLength(10).MaximumLength(10).WithMessage("Lütfen telefon numaranızı 0sız 10 haneli olucak şekilde giriniz.");
            RuleFor(x => x.Country).NotEmpty().WithMessage("Lütfen bulunduğunuz ülkeyi  giriniz.").MaximumLength(50).WithMessage("En fazla 50 karakter olabilir.");
            RuleFor(x => x.City).NotEmpty().WithMessage("Lütfen bulunduğunuz şehiri  giriniz.").MaximumLength(50).WithMessage("En fazla 50 karakter olabilir.");
            RuleFor(x => x.Address1).NotEmpty().WithMessage("Lütfen adresinizi  giriniz.").MaximumLength(200).WithMessage("Adresiniz en fazla 200 karakter olabilir.");
            RuleFor(x => x.Address2).NotEmpty().WithMessage("Lütfen adresinizi  giriniz.").MaximumLength(200).WithMessage("Adresiniz en fazla 200 karakter olabilir.");
            RuleFor(x => x.PostalCode).NotEmpty().WithMessage("Lütfen posta kodunu  giriniz.").MaximumLength(5).WithMessage("En fazla 5 karakter olabilir.");

        }
    }
}
