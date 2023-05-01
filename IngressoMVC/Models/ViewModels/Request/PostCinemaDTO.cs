using System.ComponentModel.DataAnnotations;

namespace IngressoMVC.Models.ViewModels.Request
{
    public class PostCinemaDTO
    {
            [Required(ErrorMessage = "Nome do Cinema é Obrigatório"), StringLength(50, MinimumLength = 3, ErrorMessage ="Nome do Cinema deve ter no máximo 50 caracteres, e no Minimo 3 caracteres")]
            public string Nome { get;  set; }

            public string Descricao { get;  set; }
            [Required(ErrorMessage ="Logo Obrigatória")]
            public string LogoURL { get;  set; }
    }
}