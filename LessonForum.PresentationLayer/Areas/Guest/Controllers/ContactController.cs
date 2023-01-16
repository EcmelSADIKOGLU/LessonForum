using LessonForum.BusinessLayer.Abstract;
using LessonForum.EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using System;

namespace LessonForum.PresentationLayer.Areas.Guest.Controllers
{
    [Area("Guest")]
    [Route("Guest/Contact")]
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [Route("")]
        [Route("Index")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [Route("")]
        [Route("Index")]
        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            contact.Date = DateTime.Now;
            _contactService.TInsert(contact);
            ViewBag.Message = "Mesajınız Kaydedilmiştir";
            return RedirectToAction("Index");
        }
    }
}
