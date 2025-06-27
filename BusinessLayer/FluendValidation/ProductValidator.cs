using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluendValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x=>x.ProductName).NotEmpty().WithMessage("Ürün Adını Boş geçemezsiniz.");
            RuleFor(x => x.ProductName).MinimumLength(3).WithMessage("Ürün Adı 3 Karakterden Kısa Olmaz.");
            RuleFor(x => x.ProductStock).NotEmpty().WithMessage("Stok 0 Olamaz.");
            RuleFor(x => x.ProductPrice).NotEmpty().WithMessage("Ücret 0 Olamaz");
        }
    }
}
