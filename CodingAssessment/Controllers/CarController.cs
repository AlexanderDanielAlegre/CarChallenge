using CodingAssessment.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;

namespace CodingAssessment.Controllers
{
    public class CarController : Controller
    {
        private readonly ILogger<CarController> _logger;

        private static List<CarModel> _car = CarModel.Seed();

        public CarController(ILogger<CarController> logger)
        {
            _logger = logger;

        }

        public IActionResult Index()
        {

            return View(_car);
            
        }

        public IActionResult Create()
        {
            ViewBag.Car = _car;
            return View();
        }
        [HttpPost]
        public IActionResult Create(CarModel newcar)
        {
            _car.Add(newcar);
            return View("Index", _car);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var remove = _car.Find(x=> x.Id == id);
            _car.Remove(remove);
            return View("Index", _car);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}