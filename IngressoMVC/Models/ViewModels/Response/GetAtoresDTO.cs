using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace IngressoMVC.Models.ViewModels.ResponseDTO 
{
    public class GetAtoresDTO 
    {
        [Display(Name = "Nome")]
        public string NomeCompleto { get; set; }

        [Display(Name = "Biografia")]
        public string Bio { get; set; }

        [Display(Name = "Foto")]
        public string FotoPerfilURL { get; set; }

        public List<string> NomeFilmes { get; set; }

        public List<string> FotoURLFilmes { get; set; }

    }
}