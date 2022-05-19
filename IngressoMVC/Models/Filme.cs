using IngressoMVC.Models.Interfaces;
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

        #region Relacionamentos

        // Relacionamento Cinema
        public int CinemaId { get; set; }
        public Cinema Cinema { get; set; }

        // Relacionamento Produto
        public int ProdutorId { get; set; }
        public Produtor Produtor { get; set; }
        
        // Relacionamento com a tabela auxiliar ator Filme
        public List<AtorFilme> AtorFilmes { get; set; }

        // Relacionamento com tabela auxilia Filme
        public List<FilmeCategoria> FilmeCategorias { get; set; }
        #endregion 


    }
}
