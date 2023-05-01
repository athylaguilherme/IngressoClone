using System.Linq;
using IngressoMVC.Data;
using IngressoMVC.Models;
using IngressoMVC.Models.ViewModels.Request;
using IngressoMVC.Models.ViewModels.ResponseDTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

            var resultado = _context.Atores.Include(af => af.AtorFilmes)
                .ThenInclude(f => f.Filme)
                .FirstOrDefault(ator => ator.Id == id);
           

            GetAtoresDTO atorDTO = new GetAtoresDTO()
            {
                NomeCompleto = resultado.NomeCompleto,
                Bio = resultado.Bio,
                FotoPerfilURL = resultado.FotoPerfilURL,
                FotoURLFilmes = resultado.AtorFilmes.Select(af => af.Filme.ImageURL).ToList(),
                NomeFilmes = resultado.AtorFilmes.Select(af => af.Filme.Titulo).ToList()


            };

            return View(resultado);
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



        
        public IActionResult Editar(int? id)
        {
            if(id == null){
                return View();
            }
            // Buscar ator no banco
            var result = _context.Atores.FirstOrDefault(a => a.Id == id); 
            if(result == null) {
                return View();
            }
            // passar ator na view
            return View(result);
        }

        [HttpPost]
        public IActionResult Editar(int id, PostAtorDto atorDto)
        {
            if (!ModelState.IsValid)
            {
                return View(atorDto);
            }
            // Buscar o ator no banco de dados
            var result = _context.Atores.FirstOrDefault(a => a.Id == id);
            // Atualizar os dados do ator 
            result.AtualizarDados(atorDto.NomeCompleto, atorDto.Bio, atorDto.FotoPerfilURL);

            // Atualizar isso no banco de dados
            _context.Atores.Update(result);
            // Salvar as Mudanças
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }



         public IActionResult Deletar(int id)
         {
           // Buscar ator no banco 
           var result = _context.Atores.FirstOrDefault(a => a.Id == id);
           if(result == null) return View();
            // passar ator na view
                return View(result);       
         }

         [HttpPost]

         public IActionResult ConfirmarDeletar(int id)
         {
             var result = _context.Atores.FirstOrDefault(a => a.Id == id);
             
             _context.Atores.Remove(result);
             _context.SaveChanges();

             return RedirectToAction(nameof(Index));
         }
    }
}
