using System.Linq;
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
             // Validar os dados
             if(!ModelState.IsValid || ! atorDto.FotoPerfilURL.EndsWith(".jpg"))
             {
                 return View(atorDto);
             } 


            Ator ator = new Ator(atorDto.NomeCompleto, atorDto.Bio, atorDto.FotoPerfilURL);
           
            
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
           var result = _context.Atores.FirstOrDefault(a => a.Id == id);
           if(result == null) return View();
            // passar ator na view
                return View(result);       
         }

         [HttpDelete]

         public IActionResult ConfirmarDeletar(int id)
         {
             var result = _context.Atores.FirstOrDefault(a => a.Id == id);
             
             _context.Atores.Remove(result);
             _context.SaveChanges();

             return RedirectToAction(nameof(Index));
         }
    }
}
