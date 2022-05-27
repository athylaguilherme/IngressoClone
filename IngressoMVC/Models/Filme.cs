using IngressoMVC.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Models
{
    public class Filme : IEntidade
    {
        public Filme(string titulo, string descricao, decimal preco, string imageURL)
        {
            Titulo = titulo;
            Descricao = descricao;
            Preco = preco;
            ImageURL = imageURL;
        }

        public Filme(string titulo, string descricao, decimal preco, string imageURL, int cinemaId, int produtorId)
        {
            Titulo = titulo;
            Descricao = descricao;
            Preco = preco;
            ImageURL = imageURL;
            CinemaId = cinemaId;
            ProdutorId = produtorId;
        }

        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteração { get; set; }
        public string Titulo { get; private set; }
        public string Descricao { get;  private set; }
        public decimal Preco { get; private set; }
        public string ImageURL { get; private set; }

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

        public void AlterarPreco(Decimal novoPreco)
        {
            if (novoPreco < 0)
            {
                return;
            }
            else { Preco = novoPreco; }
        }

    }
}
