using Microsoft.AspNetCore.Mvc;
using Services;
using ServiceContracts;

namespace DIExample.Controllers
{
    public class HomeController : Controller
    {
        // should never create an object of a service class in controller
        // 
        // instead should use dependency injection
        private readonly ICitiesService _citiesService;

        public HomeController(ICitiesService citiesService)
        {
            _citiesService = citiesService;//new CitiesService();
        }

        [Route("/")]
        public IActionResult Index()
        {
            var cities = _citiesService.GetCities();
            return View(cities);
        }
    }
}
