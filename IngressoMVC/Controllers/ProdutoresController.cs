using IngressoMVC.Data;
using IngressoMVC.Models;
using Microsoft.AspNetCore.Mvc;


public class ProdutoresController : Controller
    {
        private IngressoDbContext _context;

        public ProdutoresController(IngressoDbContext context)
        {
            _context = context;
        }

        public ActionResult<Produtor> Index()
        {
            return View(_context.Produtores);
        }

         public IActionResult Detalhes(int id)
        {
            var result = _context.Produtores.Find(id);

            return View(result);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }


        public IActionResult Editar(int id)
        {
            // Buscar produtores no banco 
            // passar produtores na view
            return View();
        }

         public IActionResult Deletar(int id)
         {
           // Buscar produtores no banco 
            // passar produtores na view
             
                return View();       
         }
    }