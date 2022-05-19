using IngressoMVC.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Models
{
    public class Categoria : IEntidade
    {
        public Categoria( string nome)
        {
            Nome = nome;
        }

        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteração { get; set; }
        public string Nome { get; private set; }

        // Relacionamento com tabela auxilia Filme
        public List<FilmeCategoria> FilmeCategorias { get; set; }

    }
}
