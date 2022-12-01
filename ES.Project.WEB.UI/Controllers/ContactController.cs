using Microsoft.AspNetCore.Mvc;

namespace ES.Project.WEB.UI.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
