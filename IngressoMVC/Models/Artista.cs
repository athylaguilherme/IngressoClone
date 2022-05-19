using IngressoMVC.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Models
{
    public abstract class Artista : IEntidade
    {
        protected Artista(string nomeCompleto, string bio, string fotoPerfilURL)
        {
            DataCadastro = DateTime.Now;
            DataAlteração = DataCadastro;
            NomeCompleto = nomeCompleto;
            Bio = bio;
            FotoPerfilURL = fotoPerfilURL;
        }

        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteração { get; set; }
        public string NomeCompleto { get; private set; }

        public string Bio { get; private set; }

       public string FotoPerfilURL { get; private set; }
    }
}
