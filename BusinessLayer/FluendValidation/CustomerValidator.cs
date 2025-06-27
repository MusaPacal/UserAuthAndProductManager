using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluendValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.CustomerName).NotEmpty().WithMessage("Müşteri Adını Boş geçemezsiniz.");
            RuleFor(x => x.CustomerName).MinimumLength(3).WithMessage("Müşteri Adı 3 Karakterden Kısa Olamaz.");
            RuleFor(x => x.CustomerCity).NotEmpty().WithMessage("Müşteri Şehri Boş Geçilemez.");
            RuleFor(x => x.CustomerCity).MinimumLength(3).WithMessage("Müşteri Şehri 3 Karakterden Kısa Olamaz.");
        }
    }
}
