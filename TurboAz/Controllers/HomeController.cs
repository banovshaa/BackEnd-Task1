using Microsoft.AspNetCore.Mvc;
using TurboAz.Models;

namespace TurboAz.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Marka> markalar = new List<Marka>
            {
                new Marka{ Id = 1,Name="Audi"},
                new Marka{ Id = 2,Name="BMW"},
                new Marka{ Id = 3,Name="Toyota"},
                new Marka{ Id = 4,Name="Hyundai"},

            };
            return View(markalar);
        }
    }
}
