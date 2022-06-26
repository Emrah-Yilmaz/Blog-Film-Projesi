using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.AboutImage).NotEmpty().WithMessage("Resim yolu  boş geçilemez");
            RuleFor(x => x.AboutImage).MinimumLength(10).WithMessage("Resim yolu 10 karakterden az olamaz.");
            RuleFor(x => x.AboutImage).MaximumLength(200).WithMessage("Resim yolu 200 karakterden fazla olamaz.");


            RuleFor(x => x.AboutTitle).NotEmpty().WithMessage("Hakkımızda  başlığı boş geçilemez");
            RuleFor(x => x.AboutTitle).MinimumLength(3).WithMessage("Başlık bilgisi 3 karakterden az olamaz.");
            RuleFor(x => x.AboutTitle).MaximumLength(50).WithMessage("Resim yolu 50 karakterden fazla olamaz.");


            RuleFor(x => x.AboutContent1).NotEmpty().WithMessage("Hakkımızda İçeriği boş geçilemez");
            RuleFor(x => x.AboutContent1).MinimumLength(10).WithMessage("Resim yolu 10 karakterden az olamaz.");
            RuleFor(x => x.AboutContent1).MaximumLength(1000).WithMessage("İçerik 1000 karakterden fazla olamaz.");


            RuleFor(x => x.OurAddress).NotEmpty().WithMessage("Adres bilgisi  boş geçilemez");
            RuleFor(x => x.OurAddress).MinimumLength(10).WithMessage("Adres bilgisi 10 karakterden az olamaz.");
            RuleFor(x => x.AboutTitle).MaximumLength(50).WithMessage("Adres bilgisi 50 karakterden fazla olamaz.");


            RuleFor(x => x.OurEmailAddress).NotEmpty().WithMessage("Mail adresi boş geçilemez");
            RuleFor(x => x.OurEmailAddress).MinimumLength(9).WithMessage("Mail Adresi 9 karakterden az olamaz.");
            RuleFor(x => x.OurEmailAddress).MaximumLength(100).WithMessage("Mail Adresi 100 karakterden fazla olamaz.");


            RuleFor(x => x.OurLocation).NotEmpty().WithMessage("Lokasyon bilgisi boş geçilemez");
            RuleFor(x => x.OurLocation).MinimumLength(10).WithMessage("Resim yolu 10 karakterden az olamaz.");
            RuleFor(x => x.AboutTitle).MaximumLength(50).WithMessage("Resim yolu 50 karakterden fazla olamaz.");


            RuleFor(x => x.OurPhoneNumber).NotEmpty().WithMessage("Telefon numarası boş geçilemez");
            RuleFor(x => x.OurPhoneNumber).MinimumLength(10).WithMessage("Telefon numarası 10 karakterden az olamaz.");
            RuleFor(x => x.OurPhoneNumber).MaximumLength(11).WithMessage("Telefon numarası 11 karakterden fazla olamaz.");


        }
    }
}
