using LessonForum.BusinessLayer.Abstract;
using LessonForum.EntityLayer.Entities;
using LessonForum.PresentationLayer.Areas.Guest.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using System.Data;

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
        public  IActionResult LessonNoteList(int id)
        {
            ViewBag.subcategoryID = id;

            var values = _lessonNoteService.TGetList(x => x.Status && x.SubCategory.SubCategoryID == id);
            if (User.Identity.IsAuthenticated)
            {

                ViewBag.Authenticated = true;
            }
            else
            {
                ViewBag.Authenticated = false;
            }
            

            return View(values);
        }

        [Authorize(Roles = "Admin,Yönetici,Üye")]
        [Route("")]
        [Route("AddNote/{id}")]
        [HttpGet]
        public IActionResult AddNote(int id)
        {
            ViewBag.subcategoryID = id;
            return View();
        }

        [Authorize(Roles = "Admin,Yönetici,Üye")]
        [Route("")]
        [Route("AddNote/{id}")]
        [HttpPost]
        public async Task< IActionResult> AddNote(AddLessonNoteViewModel model)
        {

            var filename = "";

            if (model.LessonFile != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extention = Path.GetExtension(model.LessonFile.FileName);
                filename = Guid.NewGuid() + extention;
                var saveLocation = resource + "/wwwroot/LessonNoteStorage/" + filename;
                var stream = new FileStream(saveLocation, FileMode.Create);
                await model.LessonFile.CopyToAsync(stream);
                
            }

            LessonNote lessonNote = new LessonNote() 
            {
                SubCategoryID = model.SubCategoryID,
                Title = model.Title,
                Description= model.Description,
                FileName = filename,
                Status = true,
                Deleted = false  
            };
            
            _lessonNoteService.TInsert(lessonNote);
            return Redirect("/Guest/Note/LessonNoteList/" + model.SubCategoryID);
            
        }

    }
}
