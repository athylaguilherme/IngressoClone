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
            Categoria categoria = new Categoria (CategoriaDto.Nome);
            // Validar os daodos 
            
            // Gravar esse ator no banco de dados 
            _context.Categorias.Add(categoria);
            // Salvar Mudanças
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Editar(int id)
        {
            // Buscar Categoria no banco 
            // passar Categoria na view
            return View();
        }

         public IActionResult Deletar(int id)
         {
           // Buscar Categoria no banco 
            // passar Categoria na view
             
                return View();       
         }
    }
}
