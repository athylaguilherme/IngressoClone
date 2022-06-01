using IngressoMVC.Data;
using IngressoMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Controllers
{
    public class AtoresController : Controller
    {
        private IngressoDbContext _context;

        public AtoresController(IngressoDbContext context)
        {
            _context = context;
        }

        // Retornando a lista Atores
        public ActionResult<Ator> Index()
        { 
             return View(_context.Atores);
        }

        // Retornando ator especifico
        public IActionResult Detalhes(int id)
        {
            var result = _context.Atores.Find(id);

            return View(result);
        }

        public IActionResult Criar()
        {
            return View();
        }


        public IActionResult Editar(int id)
        {
            // Buscar ator no banco 
            // passar ator na view
            return View();
        }

         public IActionResult Deletar(int id)
         {
           // Buscar ator no banco 
            // passar ator na view
             
                return View();       
         }
    }
}
