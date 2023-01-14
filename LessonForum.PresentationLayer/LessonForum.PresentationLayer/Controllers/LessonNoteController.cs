using LessonForum.BusinessLayer.Abstract;
using LessonForum.EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LessonForum.PresentationLayer.Controllers
{
    public class LessonNoteController : Controller
    {
        ILessonNoteService _lessonNoteService;
        ISubCategoryService _subcategoryService;
        ICategoryService _categoryService;

        public LessonNoteController(ILessonNoteService lessonNoteService, ISubCategoryService subcategoryService, ICategoryService categoryService)
        {
            _lessonNoteService = lessonNoteService;
            _subcategoryService = subcategoryService;
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var values =  _lessonNoteService.TGetListWithSubCategory(x=>!x.Deleted);
            return View(values);
        }

        
        public IActionResult DeleteLessonNote(int id)
        {
            var lessonNote = _lessonNoteService.TGetByID(id);
            lessonNote.Deleted = true;
            lessonNote.Status = false;
            _lessonNoteService.TUpdate(lessonNote);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult LessonNoteDetails(int id)
        {
            var lessonNote = _lessonNoteService.TGetLessonNoteByID(id);
            return View(lessonNote);
        }

        
    }
}
