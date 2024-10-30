using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebApi.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage ="Zorunlu alan")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Zorunlu alan")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Zorunlu alan")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Zorunlu alan")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Zorunlu alan")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Zorunlu alan")]
        [Compare("Password",ErrorMessage ="Şifreler uyuşmuyor!")]
        public string ConfirmPassword { get; set; }
    }
}
