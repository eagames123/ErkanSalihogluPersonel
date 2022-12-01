using ES.Project.Business.Abstract;
using ES.Project.Entity.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ES.Project.WEB.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DefaultController : Controller
    {
        private readonly ICategoryService _categoryService;

        public DefaultController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            List<Kategori> categories = _categoryService.GetAllCategories();

            return View(categories);
        }
    }
}
