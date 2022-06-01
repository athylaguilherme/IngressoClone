using IngressoMVC.Data;
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
            return View();
        }


        public IActionResult Cadastrar()
        {
            return View();
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
