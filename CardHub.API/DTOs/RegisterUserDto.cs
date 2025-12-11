using System.ComponentModel.DataAnnotations;

namespace CardHub.API.DTOs
{
    public class RegisterUserDto
    {
        [Required(ErrorMessage = "O nome de usuário é obrigatório.")]
        [StringLength(50, ErrorMessage = "O nome de usuário não pode passar de 50 caracteres.")]
        public string Username { get; set; } = string.Empty;

        [Required(ErrorMessage = "O email é obrigatório.")]
        [EmailAddress(ErrorMessage = "O email fornecido não é válido.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "A senha é obrigatória.")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "A senha deve ter entre 6 e 100 caracteres.")]
        public string Password { get; set; } = string.Empty;

        [Compare(nameof(Password), ErrorMessage = "As senhas não coincidem.")]
        public string PasswordConfirmation { get; set; } = string.Empty;
    }
}