using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog başlığı boş geçilemez");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog görseli boş geçilemez");
            RuleFor(x => x.CategoryId).NotEmpty().WithMessage("Blog görseli boş geçilemez");
            RuleFor(x => x.FilmTimeInfo).NotEmpty().WithMessage("Filme süresi boş geçilemez");
            RuleFor(x => x.Director).NotEmpty().WithMessage("Yönetmen bilgisi boş geçilemez");
            RuleFor(x => x.Imdb).NotEmpty().WithMessage("IMDB boş geçilemez");
            RuleFor(x => x.TrailerUrl).NotEmpty().WithMessage("Fragman linki boş geçilemez");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog içeriği boş geçilemez");
            RuleFor(x => x.BlogContent).MinimumLength(20).WithMessage("Blog içeriği 20 karakterden az olamaz");
            RuleFor(x => x.BlogContent).MaximumLength(1500).WithMessage("Blog içeriği 1500 karakterden fazla olamaz"); 
        }
    }
}
