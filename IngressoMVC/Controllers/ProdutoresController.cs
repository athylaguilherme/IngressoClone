using System.Linq;
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
            // Validando se o id não Nulo
            if(id == null){
                return View();
            }
            // Buscar produtor no banco
            var result = _context.Produtores.FirstOrDefault(p => p.Id == id);
            // Verificando se o produtor buscado no banco de dados é valido
            if(result == null){
                return View();
            } 
            // passar produtores na view
            return View(result);
        }

        [HttpPost]
        public IActionResult Editar(int id, PostProdutorDTO produtorDto)
        {
             if (!ModelState.IsValid)
            {
                return View(produtorDto);
            }
            //Buscando o produtor no banco de dados 
            var result = _context.Produtores.FirstOrDefault(p => p.Id == id);
            // Atualizando os dados com o metodo da model
            result.AtualizarDados(produtorDto.NomeCompleto, produtorDto.Bio, produtorDto.FotoPerfilURL);
            // Atualizando no banco de dados as mudanças 
            _context.Update(result);
            //Salvando as Mundaças no banco de dados 
            _context.SaveChanges();
            // Redirecionando para Index do Produtor
            return RedirectToAction(nameof(Index)); 
        }

         public IActionResult Deletar(int id)
         {
           // Buscar produtores no banco 
           var result = _context.Produtores.FirstOrDefault(p => p.Id == id);
           if(result == null) return View();
            // passar produtores na view
                return View(result);       
         }

         [HttpPost]

         public IActionResult ConfirmarDeletar(int id)
         {
            //Buscando Produtor no banco de dados e guardando na variavel
            var result = _context.Produtores.FirstOrDefault(p => p.Id == id);
            // Removendo Produtor no banco de daods
            _context.Produtores.Remove(result);
            // Salvando no Banco as Mundaças
            _context.SaveChanges();
            // Redirecionando para Pagina Index
            return RedirectToAction(nameof(Index));

         }
    }