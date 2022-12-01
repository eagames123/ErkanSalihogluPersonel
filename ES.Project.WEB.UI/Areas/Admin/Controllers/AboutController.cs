using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ES.Project.WEB.UI.Areas.Admin.Controllers
{
    //[AllowAnonymous]
    [Area("Admin")]
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult InsertCategoryPage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult InsertCategory()
        {
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateCategoryPage(int categoryId)
        {
            return View();
        }

        [HttpPost]
        public IActionResult UpdateCategory()
        {
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteCategoryPage(int categoryId)
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeleteCategory()
        {
            return RedirectToAction("");
        }

        [HttpGet]
        public IActionResult DetailCategoryPage(int categoryId)
        {
            return View();
        }
        
    }
}
