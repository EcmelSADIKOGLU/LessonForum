using LessonForum.BusinessLayer.Abstract;
using LessonForum.EntityLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Data;

namespace LessonForum.PresentationLayer.Controllers
{
    [Authorize(Roles = "Admin,Yönetici")]
    public class SubCategoryController : Controller
    {
        ISubCategoryService _subcategoryService;
        ICategoryService _categoryService;

        public SubCategoryController(ISubCategoryService subcategoryService, ICategoryService categoryService)
        {
            _subcategoryService = subcategoryService;
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var values = _subcategoryService.TGetListWithCategory(x=>!x.Deleted);
            return View(values);
        }

        [HttpGet]
        public IActionResult AddSubCategory()
        {
            var categoyList = _categoryService.TGetList(x => !x.Deleted);
            List<SelectListItem> categoryList = new List<SelectListItem>();
            foreach (var item in categoyList)
            {
                categoryList.Add(new SelectListItem()
                {
                    Text = item.Name,
                    Value = item.CategoryID.ToString()
                });
            }
            ViewBag.categoryList = categoryList;
            return View();
        }

        [HttpPost]
        public IActionResult AddSubCategory(SubCategory subcategory)
        {

            _subcategoryService.TInsert(subcategory);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteSubCategory(int id)
        {
            var subcategory = _subcategoryService.TGetByID(id);
            subcategory.Deleted = true;
            subcategory.Status = false;
            _subcategoryService.TUpdate(subcategory);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditSubCategory(int id)
        {
            var categoyList = _categoryService.TGetList(x => !x.Deleted);
            List<SelectListItem> categoryList = new List<SelectListItem>();
            foreach (var item in categoyList)
            {
                categoryList.Add(new SelectListItem()
                {
                    Text = item.Name,
                    Value = item.CategoryID.ToString()
                });
            }
            ViewBag.categoryList = categoryList;

            var subcategory = _subcategoryService.TGetByID(id);
            return View(subcategory);
        }

        [HttpPost]
        public IActionResult EditSubCategory(SubCategory subcategory)
        {
            _subcategoryService.TUpdate(subcategory);
            return RedirectToAction("Index");
        }
    }
}
