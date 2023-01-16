using LessonForum.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace LessonForum.PresentationLayer.ViewComponents.Layout
{
    public class NavbarComponent:ViewComponent
    {
        
        public IViewComponentResult Invoke()
        {
            if (User.Identity.IsAuthenticated)
            {
                ViewBag.Authenticated = true;
            }
            else
            {
                ViewBag.Authenticated = false;
            }
            return View();
        }
    }
}
