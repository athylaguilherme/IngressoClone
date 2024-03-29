﻿using IngressoMVC.Data;
using IngressoMVC.Models;
using IngressoMVC.Models.ViewModels.Request;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Controllers
{
    public class FilmesController : Controller
    {
        private IngressoDbContext _context;

        public FilmesController(IngressoDbContext context)
        {
            _context = context;
        }

        public ActionResult<Filme> Index()
        {
            return View(_context.Filmes);
        }

         public IActionResult Detalhes(int id)
        {
            var result = _context.Filmes.Find(id);

            return View(result);
        }


        public IActionResult Cadastrar()
        {
          return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(PostFilmeDTO filmeDTO)
        {
            var Cinema = _context.Cinemas.FirstOrDefault(c => c.Nome == filmeDTO.NomeCinema);
            if(Cinema == null)
            {
                return View();
            }
            
            var Produtor = _context.Produtores.FirstOrDefault(p => p.NomeCompleto == filmeDTO.NomeProdutor);

            if(Produtor == null)
            {
                return View();
            }

            Filme filme = new Filme(filmeDTO.Titulo, filmeDTO.Descricao, filmeDTO.Preco, filmeDTO.ImageURL);

            _context.Filmes.Add(filme);
            _context.SaveChanges();
            return View();
        }

        [HttpPost]
        public IActionResult CriarFilmeComCategoriasAtores(PostFilmeDTO filmeDto)
        {
            var cinema = _context.Cinemas.FirstOrDefault(c => c.Nome == filmeDto.NomeCinema);
            if (cinema == null) return View();

            var produtor = _context.Produtores.FirstOrDefault(p => p.Nome == filmeDto.NomePodutor);
            if (produtor == null) return View();

            Filme filme = new Filme
                (
                    filmeDto.Titulo,
                    filmeDto.Descricao,
                    filmeDto.Preco,
                    filmeDto.ImageURL,
                    cinema.Id,
                    produtor.Id
                );

            _context.Add(filme);
            _context.SaveChanges();

            //Incluir Relacionamentos
            foreach (var categoriaId in filmeDto.CategoriasId)
            {
                var novaCategoria = new FilmeCategoria(filme.Id, categoriaId);
                _context.FilmesCategorias.Add(novaCategoria);
                _context.SaveChanges();
            }

            foreach (var atorId in filmeDto.AtoresId)
            {
                var novoAtor = new AtorFilme(atorId, filme.Id);
                _context.AtoresFilmes.Add(novoAtor);
                _context.SaveChanges();
            }

            return RedirectToAction(nameof(Index));

        }
        public IActionResult Editar(int id)
        {
            // Buscar Filme no banco 
            // passar Filme na view
            return View();
        }

         public IActionResult Deletar(int id)
         {
           // Buscar Filme no banco 
            // passar Filme na view
             
                return View();       
         }
    }
}
