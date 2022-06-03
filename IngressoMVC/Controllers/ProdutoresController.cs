using IngressoMVC.Data;
using IngressoMVC.Models;
using IngressoMVC.Models.ViewModels.Request;
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

        [HttpPost]
        public IActionResult Cadastrar(PostProdutorDTO produtorDTO)
        {
            // Validar dados
              if(!ModelState.IsValid)
             {
                 return View(produtorDTO);
             } 


            Produtor produtor = new Produtor(produtorDTO.NomeCompleto, produtorDTO.Bio, produtorDTO.FotoPerfilURL);
            _context.Produtores.Add(produtor);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
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