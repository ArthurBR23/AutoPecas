using Microsoft.AspNetCore.Mvc;
using Pecas.Models;

namespace Pecas.Controllers
{
    public class FornecedorController : Controller
    {
        private static IList<Fornecedor> Fornecedores = new List<Fornecedor>()
        {
            new Fornecedor()
            {
                FornecedorId = 1,
                Nome = "Lucas",
                Pais = "China",
            },

            new Fornecedor()
            {
                FornecedorId = 2,
                Nome = "Caio",
                Pais = "Brasil"
            }
        };
        public IActionResult Index()
        {
            return View(Fornecedores);
        }
    }
}
