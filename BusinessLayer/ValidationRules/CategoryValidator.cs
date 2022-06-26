using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator: AbstractValidator<Category>
    {

        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Blog başlığı boş geçilemez");
            RuleFor(x => x.CategoryName).MinimumLength(2).WithMessage("Kategori Adı 2 karakterden az olamaz.");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("Kategori Adı 20 karakterden fazla olamaz.");
            RuleFor(x => x.CategoryDescription).MaximumLength(100).WithMessage("Kategori Adı 100 karakterden fazla olamaz.");

        }
    }
}
