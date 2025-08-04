using System.ComponentModel.DataAnnotations;

namespace Core_ProjeUdmy.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen adınızı giriniz.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen soyadınızı giriniz.")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen kullanıcı adını giriniz.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen resim yolunu giriniz.")]
        [Display(Name = "Profil Resmi")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi giriniz.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi tekrar giriniz.")]
        [Compare("Password", ErrorMessage = "Şifreler uyuşmuyor.")]
        [DataType(DataType.Password)]
        [Display(Name = "Şifre Tekrar")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Lütfen e-posta adresinizi giriniz.")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz.")]
        public string Mail { get; set; }
    }
}
