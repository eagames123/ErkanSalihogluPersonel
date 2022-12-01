using ES.Project.Business.Abstract;
using ES.Project.Entity.Entities;
using ES.Project.WEB.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ES.Project.WEB.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryService _categoryService;
        
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ICategoryService categoryService)
        {
            _logger = logger;
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            List<Kategori> categories = _categoryService.GetAllCategories();

            return View(categories);
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