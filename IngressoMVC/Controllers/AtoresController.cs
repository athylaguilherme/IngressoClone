using IngressoMVC.Data;
using IngressoMVC.Models;
using IngressoMVC.Models.ViewModels.Request;
using Microsoft.AspNetCore.Mvc;


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

       
        [HttpPost]
        public IActionResult Criar(PostAtorDto atorDto)
        {
            Ator ator = new Ator(atorDto.NomeCompleto, atorDto.Bio, atorDto.FotoPerfilURL);
            // Validar os daodos 
            
            // Gravar esse ator no banco de dados 
            _context.Atores.Add(ator);
            // Salvar Mudanças
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
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
