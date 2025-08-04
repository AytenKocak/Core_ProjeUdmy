using System.ComponentModel.DataAnnotations;

namespace Core_ProjeUdmy.Areas.Writer.Models
{
    public class UserLoginViewModel
    {
        [Display (Name="Kullanıcı Adı")]
        [Required (ErrorMessage ="Kullanıc Adını Giriniz")]
        public string UserName { get; set; }

        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Şifreyi Giriniz")]
        public string Password { get; set; }
    }
}
