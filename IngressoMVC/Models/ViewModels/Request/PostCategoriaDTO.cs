using System.ComponentModel.DataAnnotations;

namespace IngressoMVC.Models.ViewModels.Request
{
    public class PostCategoriaDTO
    {
        [Required(ErrorMessage = "Nome da categoria é Obrigatório"), StringLength(50, MinimumLength = 3, ErrorMessage ="Nome do Cinema deve ter no máximo 50 caracteres, e no Minimo 3 caracteres")]
            public string Nome { get;  set;} 
    }
}