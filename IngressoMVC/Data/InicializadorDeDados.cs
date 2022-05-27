using IngressoMVC.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Data
{
    public class InicializadorDeDados
    {
        public static void Inicializar(IApplicationBuilder builder)
        {
            using (var serviceScope = builder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<IngressoDbContext>();

                context.Database.EnsureCreated();

                if (!context.Cinemas.Any())
                {
                    //Instanciar novos Cinemas
                    context.Cinemas.Add(new Cinema("Cinemark", "Bio desc...", "https://logodownload.org/wp-content/uploads/2017/11/cinemark-logo.png"));
                    context.SaveChanges();
                }

                if(!context.Atores.Any())
                {
                    context.Atores.AddRange(new List<Ator>()
                    {
                        new Ator("Robert Downey Jr","Bio desc....","https://www.themoviedb.org/t/p/w300_and_h450_bestv2/5qHNjhtjMD4YWH3UP0rm4tKwxCL.jpg"),
                        new Ator("Andrew Garfield","Bio desc...","https://www.themoviedb.org/t/p/w300_and_h450_bestv2/slPWN0VvYJtNOEuxlFSsXSNQMaF.jpg"),
                        new Ator("Gwyneth Paltrow","Bio desc...","https://www.themoviedb.org/t/p/w300_and_h450_bestv2/slPWN0VvYJtNOEuxlFSsXSNQMaF.jpg")
                    });
                    context.SaveChanges();
                }
                if (!context.Produtores.Any())
                {
                    context.Produtores.AddRange(new List<Produtor>()
                    {
                        new Produtor("Christopher Nolan","Bio Desc...","https://www.themoviedb.org/t/p/w300_and_h450_bestv2/xuAIuYSmsUzKlUMBFGVZaWsY3DZ.jpg"),
                        new Produtor("Tim Burton","Bio Desc...","https://www.themoviedb.org/t/p/w300_and_h450_bestv2/gRM4lGpiBINAyiXaxEeJFDKzmge.jpg"),
                        new Produtor("Brian Oliver","Bio Desc...","https://www.themoviedb.org/t/p/w300_and_h450_bestv2/jjRoepjAT6nDzNEglANnM9ppPxa.jpg")
                        
                    });
                    context.SaveChanges();
                }

                if(!context.Categorias.Any())
                {
                    context.Categorias.AddRange(new List<Categoria>()
                    { new Categoria("Ação"),
                      new Categoria("Aventura"),
                      new Categoria("Ficção"),
                      new Categoria("Romance"),
                      new Categoria("Esporte")
                      


                    });
                    context.SaveChanges();
                }

                if (!context.Filmes.Any())
                {
                    context.Filmes.AddRange(new List<Filme>()
                    {
                        new Filme("Até o Último Homem","Desmond T. Doss, foi o médico do Exército Americano da Segunda Guerra Mundial, que serviu durante a Batalha de Okinawa, se recusando a matar pessoas, tornando-se o primeiro homem da história americana a receber a Medalha de Honra sem disparar um tiro.",20,"https://www.themoviedb.org/t/p/w300_and_h450_bestv2/88sCL8OQMoieKpHClqRCCbcgH6w.jpg",1,2),
                        new Filme("Homem de Ferro 2","Em um mundo ciente da existência do Homem de Ferro, o inventor bilionário Tony Stark sofre pressão de todos os lados para compartilhar sua tecnologia com as forças armadas",2,"https://www.themoviedb.org/t/p/w300_and_h450_bestv2/vzROjQbgKWMVf2EldXipCcjpuBL.jpg",1,1)
                    }) ;
                    context.SaveChanges();
                }

                if (!context.FilmesCategorias.Any())
                {
                    context.FilmesCategorias.AddRange(new List<FilmeCategoria>()
                    {
                        new FilmeCategoria(2,2),
                        new FilmeCategoria(2,3),
                        new FilmeCategoria(1,1),
                       
                    });
                    context.SaveChanges();
                }

                if (!context.AtoresFilmes.Any())
                {
                    context.AtoresFilmes.AddRange(new List<AtorFilme>()
                    {
                        new AtorFilme(1,1),
                        new AtorFilme(2,1),
                        new AtorFilme(3,1),
                       

                    });
                    context.SaveChanges();

                }
            }
        }
    }
}
