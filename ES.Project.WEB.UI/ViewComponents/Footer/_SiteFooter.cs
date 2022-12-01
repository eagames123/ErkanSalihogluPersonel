using Microsoft.AspNetCore.Mvc;

namespace ES.Project.WEB.UI.ViewComponents.Footer
{
    public class _SiteFooter : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
