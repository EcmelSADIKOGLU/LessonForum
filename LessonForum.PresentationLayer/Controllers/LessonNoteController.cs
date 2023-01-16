using LessonForum.BusinessLayer.Abstract;
using LessonForum.EntityLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace LessonForum.PresentationLayer.Controllers
{
    [Authorize(Roles = "Admin,Yönetici")]
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
            var values =  _lessonNoteService.TGetListWithSubCategory(x=>x.Status);
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


        public IActionResult LessonNoteDetails(int id)
        {
            var lessonNote = _lessonNoteService.TGetLessonNoteByID(id);
            return View(lessonNote);
        }

        public IActionResult BanLessonNote(int id)
        {

            var lessonNote = _lessonNoteService.TGetByID(id);
            lessonNote.Status = false;
            _lessonNoteService.TUpdate(lessonNote);
            return RedirectToAction("Index");
        }

        public IActionResult UnbanLessonNote(int id)
        {

            var lessonNote = _lessonNoteService.TGetByID(id);
            lessonNote.Status = true;
            _lessonNoteService.TUpdate(lessonNote);
            return RedirectToAction("Index");
        }

        public IActionResult BannedLessonNoteList()
        {
            var values = _lessonNoteService.TGetListWithSubCategory(x => !x.Deleted && !x.Status);
            return View(values);
        }

    }
}
