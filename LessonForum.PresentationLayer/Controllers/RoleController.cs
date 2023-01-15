using LessonForum.BusinessLayer.Abstract;
using LessonForum.EntityLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace LessonForum.PresentationLayer.Controllers
{
    public class RoleController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;
        
        public RoleController(RoleManager<AppRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            
            var values = _roleManager.Roles.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddRole()
        {

             return View();
        }

        [HttpPost]
        public async Task< IActionResult> AddRole(AppRole role)
        {
            role.Status = true;
            await _roleManager.CreateAsync(role);
            return RedirectToAction("Index");
        }
        public async Task< IActionResult> DeleteRole(int id)
        {
            var role = await _roleManager.FindByIdAsync(id.ToString());
            await _roleManager.DeleteAsync(role);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> EditRole(int id)
        {
            var role = await _roleManager.FindByIdAsync(id.ToString());
            return View(role);
        }

        [HttpPost]
        public async Task<IActionResult> EditRole(AppRole role)
        {
            
            var newRole = await _roleManager.FindByIdAsync(role.Id.ToString());
            newRole.Status = role.Status;
            newRole.Name = role.Name;
            await _roleManager.UpdateAsync(newRole);

            return RedirectToAction("Index");
        }
    }
}
