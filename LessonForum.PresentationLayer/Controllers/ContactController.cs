using LessonForum.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Linq;

namespace LessonForum.PresentationLayer.Controllers
{
    [Authorize(Roles = "Admin,Yönetici")]
    public class ContactController : Controller
    {
        IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            var value = _contactService.TGetList().OrderByDescending(x=>x.Date).ToList();
            return View(value);
        }

        public IActionResult DeleteContact(int id)
        {
            var value = _contactService.TGetByID(id);
            _contactService.TDelete(value);
            return RedirectToAction("Index");
        }
        public IActionResult ContactDetails(int id)
        {
            var value = _contactService.TGetByID(id);

            return View(value);
        }

    }
}
