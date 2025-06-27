using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluendValidation
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori İsmi Boş Olamaz.");
            RuleFor(x => x.CategoryName).MinimumLength(5).WithMessage("Kategori İsmi 5 Karakterden Kısa Olamaz.");
            
        }
    }
}
