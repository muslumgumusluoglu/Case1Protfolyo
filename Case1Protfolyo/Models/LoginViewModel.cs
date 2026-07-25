using System.ComponentModel.DataAnnotations;

namespace Case1Protfolyo.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Kullanıcı Adı boş geçilemez")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Şifre boş geçilemez")]
        public string Password { get; set; }
    }
}
