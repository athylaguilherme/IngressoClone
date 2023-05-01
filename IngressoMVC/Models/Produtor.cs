using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Models
{
    public class Produtor : Artista
    {
        public Produtor(string nomeCompleto, string bio, string fotoPerfilURL) : base(nomeCompleto, bio, fotoPerfilURL)
        {
        }

        public List<Filme> Filmes { get; set; }
    }
}
