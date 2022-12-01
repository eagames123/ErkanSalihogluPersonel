using Microsoft.AspNetCore.Mvc;

namespace ES.Project.WEB.UI.ViewComponents.LeftSideBar
{
    public class _Navbar:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
