using System.ComponentModel.DataAnnotations;

namespace IngressoMVC.Models.ViewModels.Request
{
    public class PostProdutorDTO
    {
        [Required(ErrorMessage = "Nome do Produtor é Obrigatório")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Nome do Produtor deve ter no máximo 50 caracteres, e no Minimo 3 caracteres")]
        public string NomeCompleto { get;  set; }
        [Required(ErrorMessage = "Biografia Obrigatória")]
        [StringLength(500, MinimumLength = 10, ErrorMessage = "A Biografia deve ter no máximo 500 caracteres, e no Minimo 10 caracteres")]
        
        public string Bio { get;  set; }
        public string FotoPerfilURL { get;  set; }
    }
}