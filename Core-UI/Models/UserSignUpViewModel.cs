using System.ComponentModel.DataAnnotations;

namespace Core_UI.Models
{
    public class UserSignUpViewModel
    {
        [Display(Name = "Ad Soyad")]
        [Required(ErrorMessage ="Lütfen Ad Soyad giriniz")]
        public string NameSurname { get; set; }

        [Display(Name = "Şifre ")]
        [Required(ErrorMessage = "Lütfen Şifrenizi giriniz")]
        public string Password { get; set; }

        [Display(Name = "Şifre Tekrar")]
        [Required(ErrorMessage = "Lütfen Şifrenizi tekrar giriniz")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Mail Adresi ")]
        [Required(ErrorMessage = "Lütfen Mail Adresinizi giriniz")]
        public string MailAdress { get; set; }

        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "Lütfen Kullanıcı Adı giriniz")]
        public string Username { get; set; }
      
    }
}
