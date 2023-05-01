using IngressoMVC.Data;
using IngressoMVC.Models;
using IngressoMVC.Models.ViewModels.Request;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace IngressoMVC.Controllers
{
    public class CinemasController : Controller
    {
        private IngressoDbContext _context;

        public CinemasController (IngressoDbContext context)
        {
            _context = context;
        }



        public ActionResult<Cinema> Index()
        {
            return View(_context.Cinemas);
        }

         public IActionResult Detalhes(int id)
        {
            var cinema = _context.Cinemas
            .Include(c => c.Filmes)
            .FirstOrDefault(c => c.Id == id);
            if(cinema == null)
                return View("NotFound");

            return View(cinema);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(PostCinemaDTO cinemaDTO)
        {

            if(!ModelState.IsValid) return View(cinemaDTO);

            Cinema cinema = new Cinema(cinemaDTO.Nome, cinemaDTO.Descricao, cinemaDTO.LogoURL);

            //Adicionando mudança no banco de dados
            _context.Cinemas.Add(cinema);

            //Salvando Mudanças no banco
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        } 
        


        public IActionResult Editar(int id)
        {
            if (id == null)
                return View("NotFound");
            // Buscar Cinema no banco 
            var result = _context.Cinemas.FirstOrDefault(c => c.Id == id);
            if (result == null)
                return View("NotFound");
            // passar Cinema na view
            return View(result);
        }

        [HttpPost]
        public IActionResult Editar(int id, PostCinemaDTO cinema)
        {
            var result = _context.Cinemas.FirstOrDefault(c => c.Id == id);

            result.AtualizarDados(cinema.Nome, cinema.Descricao, cinema.LogoURL);

            _context.Cinemas.Update(result);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

         public IActionResult Deletar(int id)
         {
            if(id == null)
             return View("NotFound");
           // Buscar Cinema no banco 
           var result = _context.Cinemas.FirstOrDefault(cinema => cinema.Id == id);
           if(result == null)
                return View("NotFound");
            // passar Cinema na view
            _context.SaveChanges();
             
                return View(result);       
         }

         [HttpPost, ActionName("Deletar")]
         public IActionResult ConfirmarDeletar(int id)
         {
            var result = _context.Cinemas.FirstOrDefault(cinema => cinema.Id == id);
            _context.Cinemas.Remove(result);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
         }

    }
}
