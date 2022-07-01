using IngressoMVC.Data;
using IngressoMVC.Models;
using IngressoMVC.Models.ViewModels.Request;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Controllers
{
    public class CategoriasController : Controller
    {

        private IngressoDbContext _context;

        public CategoriasController(IngressoDbContext context)
        {
            _context = context;
        }

        
        public IActionResult Index()
        {
            return View(_context.Categorias);
        }


        public IActionResult Cadastrar()
        {
            return View();
        }

         [HttpPost]
        public IActionResult Cadastrar(PostCategoriaDTO CategoriaDto)
        {
            if(!ModelState.IsValid) return View(CategoriaDto);

            Categoria categoria = new Categoria (CategoriaDto.Nome);
            // Validar os daodos 
            
            // Gravar esse ator no banco de dados 
            _context.Categorias.Add(categoria);
            // Salvar Mudanças
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Editar(int? id)
        {
            if(id == null ){
                return View();
            }
            // Buscar Categoria no banco 
          var result =  _context.Categorias.FirstOrDefault(c => c.Id == id);
          if(result == null){
                return View();
          }
            // passar Categoria na view
            return View(result);
        }


        [HttpPost]
        public IActionResult Editar(int id, PostCategoriaDTO categoriaDto)
        {
            var categoria = _context.Categorias.FirstOrDefault(c => c.Id == id);
            categoria.AtualizaCategoria(categoriaDto.Nome);
            _context.Categorias.Update(categoria);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

          public IActionResult Deletar(int id)
        {
             if(id == null){
                return View();
            }
            // Buscar Categoria no banco 
            var categoria = _context.Categorias.FirstOrDefault(c => c.Id == id);
            if(categoria == null){
                return View();
            }
            return View(categoria);
        }        

        [HttpPost]
         public IActionResult ConfirmarDeletar(int? id)
         {
            if(id == null){
                return View();
            }

            var categoria = _context.Categorias.FirstOrDefault(c => c.Id == id);

            if(categoria == null){
                return View();
            }

            _context.Categorias.Remove(categoria);
            _context.SaveChanges();
             
                return RedirectToAction(nameof(Index));       
         }
    }
}
