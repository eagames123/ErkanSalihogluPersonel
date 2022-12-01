using Microsoft.AspNetCore.Mvc;

namespace ES.Project.WEB.UI.ViewComponents.LeftSideBar
{
    public class _Sidebar : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
