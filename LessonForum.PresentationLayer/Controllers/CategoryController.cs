using LessonForum.BusinessLayer.Abstract;
using LessonForum.BusinessLayer.Concrete;
using LessonForum.EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LessonForum.PresentationLayer.Controllers
{
    public class CategoryController : Controller
    {
        ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var values = _categoryService.TGetList(x=>!x.Deleted);
            return View(values);
        }

        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(Category category)
        {

            _categoryService.TInsert(category);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteCategory(int id)
        {
            var category = _categoryService.TGetByID(id);
            category.Deleted = true;
            category.Status = false;
            _categoryService.TUpdate(category);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditCategory(int id)
        {
            var category = _categoryService.TGetByID(id);
            return View(category);
        }

        [HttpPost]
        public IActionResult EditCategory(Category category)
        {
            _categoryService.TUpdate(category);
            return RedirectToAction("Index");
        }
    }
}