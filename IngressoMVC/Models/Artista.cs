using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Models
{
    public class Artista : IEntidade
    {
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteração { get; set; }
        string NomeCompleto { get; set; }

        string Bio { get; set; }

        string FotoPerfilURL { get; set; }
    }
}
