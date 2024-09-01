using Microsoft.AspNetCore.Mvc;
using Pecas.Models;

namespace Pecas.Controllers
{
    public class ClienteController : Controller
    {
        private static IList<Cliente> Clientes = new List<Cliente>()
        {
            new Cliente()
            {
                ClienteId = 1,
                Nome = "Arthur",
                Telefone = "24999873579",
                Email = "arthur@gmail.com"
            },
            new Cliente()
            {
                ClienteId= 2,
                Nome = "Ana",
                Telefone = "24999888239",
                Email = "ana@gmail.com"
            }
        };
        public IActionResult Index()
        {
            return View(Clientes);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
