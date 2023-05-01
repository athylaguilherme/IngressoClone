using System.ComponentModel.DataAnnotations;

namespace IngressoMVC.Models.ViewModels.Request
{
    public class PostAtorDto
    {
        [Required(ErrorMessage = "Nome do Ator é Obrigatório")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Nome do Ator deve ter no máximo 50 caracteres, e no Minimo 3 caracteres")]
        public string NomeCompleto { get;  set; }
        public string Bio { get;  set; }

        [Required(ErrorMessage = "Imagem Obrigatória")]
        public string FotoPerfilURL { get;  set; }
    }
}