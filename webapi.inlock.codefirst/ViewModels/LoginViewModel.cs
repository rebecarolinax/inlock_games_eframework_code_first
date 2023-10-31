using System.ComponentModel.DataAnnotations;

namespace webapi.inlock.codefirst.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "E-Mail obrigatório!")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Senha obrigatória!")]
        public string? Senha { get; set; }
    }
}
