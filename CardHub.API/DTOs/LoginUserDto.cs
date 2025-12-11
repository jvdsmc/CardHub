using System.ComponentModel.DataAnnotations;

namespace CardHub.API.DTOs
{
    public class LoginUserDto
    {
        [Required(ErrorMessage = "Informe seu e-mail ou nome de usuário.")]
        public string Identifier { get; set; } = string.Empty;

        [Required(ErrorMessage = "A senha é obrigatória.")]
        public string Password { get; set; } = string.Empty;
    }
}