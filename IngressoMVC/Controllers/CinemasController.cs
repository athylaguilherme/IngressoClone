﻿using IngressoMVC.Data;
using IngressoMVC.Models;
using IngressoMVC.Models.ViewModels.Request;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            var result = _context.Cinemas.Find(id);

            return View(result);
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
            // Buscar Cinema no banco 
            // passar Cinema na view
            return View();
        }

         public IActionResult Deletar(int id)
         {
           // Buscar Cinema no banco 
            // passar Cinema na view
             
                return View();       
         }
    }
}
