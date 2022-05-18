using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Models
{
    public class Filme : IEntidade
    {
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteração { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Preco { get; set; }
        public string ImageURL { get; set; } 


    }
}
