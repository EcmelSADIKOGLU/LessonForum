using Microsoft.AspNetCore.Mvc;

namespace LessonForum.PresentationLayer.Controllers
{
    public class LayoutController : Controller
    {
        public PartialViewResult HeadPartial()
        {
            return PartialView();
        }
        public PartialViewResult SidebarPartial()
        {
            return PartialView();
        }
        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }
        public PartialViewResult FooterPartial()
        {
            return PartialView();
        }
        public PartialViewResult JSPartial()
        {
            return PartialView();
        }
    }
}
