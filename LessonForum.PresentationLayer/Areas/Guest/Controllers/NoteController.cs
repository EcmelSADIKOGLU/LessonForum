using LessonForum.BusinessLayer.Abstract;
using LessonForum.EntityLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LessonForum.PresentationLayer.Areas.Guest.Controllers
{
    [Area("Guest")]
    [Route("Guest/Note")]
    public class NoteController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly ISubCategoryService _subcategoryService;
        private readonly ILessonNoteService _lessonNoteService;
        private readonly UserManager<AppUser> _userManager;


        public NoteController(ICategoryService categoryService, ISubCategoryService subcategoryService, ILessonNoteService lessonNoteService, UserManager<AppUser> userManager)
        {
            _categoryService = categoryService;
            _subcategoryService = subcategoryService;
            _lessonNoteService = lessonNoteService;
            _userManager = userManager;
        }

        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {
           var values = _categoryService.TGetList(x=>x.Status);
            return View(values);
        }

        [Route("")]
        [Route("SubCategoryList/{id}")]
        public IActionResult SubCategoryList(int id)
        {
            var values = _subcategoryService.TGetList(x => x.Status && x.Category.CategoryID == id);
            return View(values);
        }

        [Route("")]
        [Route("LessonNoteList/{id}")]
        public  async Task< IActionResult> LessonNoteList(int id)
        {
            var values = _lessonNoteService.TGetList(x => x.Status && x.SubCategory.SubCategoryID == id);
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var roles = await _userManager.GetRolesAsync(user);
            ViewBag.Role = roles[0];

            return View(values);
        }
    }
}
