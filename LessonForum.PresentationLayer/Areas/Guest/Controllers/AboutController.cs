using Microsoft.AspNetCore.Mvc;

namespace LessonForum.PresentationLayer.Areas.Guest.Controllers
{
    [Area("Guest")]
    [Route("Guest/About")]
    public class AboutController : Controller
    {
        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
