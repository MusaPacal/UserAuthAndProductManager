using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluendValidation
{
    public class JobValidator : AbstractValidator<Job>
    {
        public JobValidator()
        {
            RuleFor(x => x.JobName).NotEmpty().WithMessage("Kategori İsmi Boş Olamaz.");
            RuleFor(x => x.JobName).MinimumLength(5).WithMessage("Kategori İsmi 5 Karakterden Kısa Olamaz.");
        }
    }
}
