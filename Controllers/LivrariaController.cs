using CP1.Net.Models;
using Microsoft.AspNetCore.Mvc;

namespace CP1.Net.Controllers
{
    public class LivrariaController : Controller
    {

        public IActionResult Index()
        {
            var livros = new List<Livro> 
            {
                new Livro
                {
                    Titulo = "A Princesa e o sapo",
                    Autor = new Autor { Nome = "Disney" },
                    Preco = 25.50m,
                    QuantidadeDisponivel = 10,
                    ISBN = "9781234567890"
                },
                new Livro
                {
                    Titulo = "Orgulho e Preconceito",
                    Autor = new Autor { Nome = "Jane Austen" },
                    Preco = 18.90m,
                    QuantidadeDisponivel = 15,
                    ISBN = "9780987654321"
                },
                new Livro
                {
                    Titulo = "1984",
                    Autor = new Autor { Nome = "George Orwell" },
                    Preco = 30.20m,
                    QuantidadeDisponivel = 8,
                    ISBN = "9789876543210"
                }
            };

            return View(livros);
        }
    }
}

