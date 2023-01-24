using Microsoft.AspNetCore.Mvc;
using TurboAz.Models;

namespace TurboAz.Controllers
{
    public class CarController : Controller
    {
        private readonly List<Car> _cars;
        public CarController()
        {
            _cars = new List<Car> { 
            
                new Car {Id=1, Year=2014, Power=1.4, modelId=1 },
                new Car {Id=2, Year=2011, Power=1.6, modelId=2 },
                new Car {Id=3, Year=2014, Power=2.0, modelId=2 },
                new Car {Id=4, Year=2018, Power=2.0, modelId=3 },
                new Car {Id=5, Year=2013, Power=2.4, modelId=3 },
                new Car {Id=6, Year=2013, Power=2.1, modelId=3 },
                new Car {Id=7, Year=2015, Power=1.0, modelId=4 },
                new Car {Id=8, Year=2022, Power=3.0, modelId=5 },
                new Car {Id=9, Year=2002, Power=3.3, modelId=5 },
                new Car {Id=10, Year=2013, Power=4.4, modelId=6 },
                new Car {Id=11, Year=2015, Power=4.0, modelId=6 },
                new Car {Id=12, Year=2013, Power=4.4, modelId=6 },
                new Car {Id=13, Year=2022, Power=2.0, modelId=7 },
                new Car {Id=14, Year=2020, Power=2.2, modelId=7 },
                new Car {Id=15, Year=2021, Power=3.5, modelId=8 },
                new Car {Id=16, Year=2008, Power=2.7, modelId=9 },
                new Car {Id=17, Year=2007, Power=2.0, modelId=9 },
                new Car {Id=18, Year=2018, Power=3.5, modelId=9 },
                new Car {Id=19, Year=2020, Power=1.6, modelId=10 },
                new Car {Id=20, Year=2014, Power=2.2, modelId=11 },
                new Car {Id=21, Year=2016, Power=2.0, modelId=11 },
                new Car {Id=22, Year=2012, Power=1.7, modelId=12 },
            };
        }
        public IActionResult Index(int?id)
        {
            if (id == null)
            {
                return View(_cars);
            }
            if (_cars.Exists(c=>c.modelId==id))
            {
                return View(_cars.FindAll(c => c.modelId == id));
            }
            else
            {
                return NotFound();
            }
        }
        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            if (_cars.Exists(c => c.Id == id))
            {
                return View(_cars.Find(c => c.Id == id));
            }
            else
            {
                return NotFound();
            }
        }
    }
}
