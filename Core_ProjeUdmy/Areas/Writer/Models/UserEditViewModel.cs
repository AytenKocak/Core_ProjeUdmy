using Microsoft.AspNetCore.Http;

namespace Core_ProjeUdmy.Areas.Writer.Models
{
    public class UserEditViewModel
    {
        public string  Name { get; set; }
        public string  Surname { get; set; }
        public string  Password { get; set; }
        public string SurnamePasswordConfirm { get; set; }
        public string PictureURL{ get; set; }
        public IFormFile Picture{ get; set; }
        //bu class üzerinden güncellemeyi deneyiyo  olacağız

    }
}
