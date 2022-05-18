using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Models
{
    public class Ator : Artista
    {
        // Relacionamento com a tabela auxiliar
        public List<AtorFilme> AtorFilmes { get; set; }

    }
}
