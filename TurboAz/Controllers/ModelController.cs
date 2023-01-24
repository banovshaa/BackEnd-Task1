using Microsoft.AspNetCore.Mvc;
using TurboAz.Models;

namespace TurboAz.Controllers
{
    public class ModelController : Controller
    {
        private readonly List<Model> _models;
        public ModelController()
        {
            _models = new List<Model>
            {
                new Model{ Id = 1,Name="A1",markaId=1},
                new Model{ Id = 2,Name="A3",markaId=1},
                new Model{ Id = 3,Name="A5",markaId=1},
                new Model{ Id = 4,Name="i3",markaId=2},
                new Model{ Id = 5,Name="X5",markaId=2}, 
                new Model{ Id = 6,Name="M6",markaId=2},
                new Model{ Id = 7,Name="C-HR",markaId=3},
                new Model{ Id = 8,Name="Land Cruiser",markaId=3},
                new Model{ Id = 9,Name="Prado",markaId=3},
                new Model{ Id = 10,Name="Accent",markaId=4}, 
                new Model{ Id = 11,Name="Santa Fe",markaId=4}, 
                new Model{ Id = 12,Name="i40",markaId=4},

            };
        }
        public IActionResult Index(int? id)
        {
            if (id == null)
            {
                return View(_models);
            }
            if(_models.Exists(m=>m.markaId == id))
            {
                return View(_models.FindAll(m=>m.markaId==id));
            }
            else
            {
                return NotFound();
            }
            
        }
    }
}
