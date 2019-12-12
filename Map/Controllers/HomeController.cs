using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Map.Models;
using AutoMapper;
using ASPNETCORE_AUTOMAPPER.Models;

namespace Map.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
namespace ASPNETCORE_AUTOMAPPER.Controllers
{
    public class MapController : Controller
    {
        private readonly IMapper _mapper;
        public MapController(IMapper mapper)
        {
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public MakeModel Post([FromBody] Make make)
        {
            MakeModel mkmodel = new MakeModel();
            mkmodel = _mapper.Map<Make, MakeModel>(make);
            return mkmodel;
        }
    }
}