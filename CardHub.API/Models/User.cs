using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CardHub.API.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome de usuário é obrigatório.")]
        [StringLength(50, ErrorMessage = "O nome de usuário não pode passar de 50 caracteres.")]
        public string Username { get; set; } = string.Empty;

        [Required(ErrorMessage = "O email é obrigatório.")]
        [EmailAddress(ErrorMessage = "O email fornecido não é válido.")]
        public string Email { get; set; } = string.Empty;

        [Required]
        [StringLength(255)]
        [JsonIgnore]
        public string PasswordHash { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}