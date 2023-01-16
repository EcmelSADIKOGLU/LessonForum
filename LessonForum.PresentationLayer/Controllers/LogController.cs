using LessonForum.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Linq;

namespace LessonForum.PresentationLayer.Controllers
{
    [Authorize(Roles = "Admin")]
    public class LogController : Controller
    {
        ILogService _logService;

        public LogController(ILogService logService)
        {
            _logService = logService;
        }

        public IActionResult Index()
        {
            var values = _logService.TGetList().OrderByDescending(x => x.LogDate).ToList();
            return View(values);
        }
    }
}
