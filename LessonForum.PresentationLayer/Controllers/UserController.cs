using LessonForum.BusinessLayer.Abstract;
using LessonForum.DataAccessLayer.Concrete;
using LessonForum.EntityLayer.Entities;
using LessonForum.PresentationLayer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace LessonForum.PresentationLayer.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly ILogService _logService;


        public UserController(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager, ILogService logService)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _logService = logService;
        }

        public async Task<IActionResult> Index()
        {
            var values = _userManager.Users.Where(x=>x.Status).
                Except(_userManager.Users.Where(x => x.UserName == User.Identity.Name)).ToList();
            List<UserListWithRoleModel> userList = new List<UserListWithRoleModel>();
            foreach (var item in values)
            {
                var user = await _userManager.FindByIdAsync(item.Id.ToString());
                var role = await _userManager.GetRolesAsync(user);


                userList.Add(new UserListWithRoleModel
                {
                    Id = item.Id,
                    Name = item.Name,
                    Surname = item.Surname,
                    Role = role[0],
                    Status = item.Status
                });
            }
            return View(userList);
        }

        [HttpGet]
        public async Task<IActionResult> UserDetails(int id)
        {

            var user = await _userManager.FindByIdAsync(id.ToString());
            var role = await _userManager.GetRolesAsync(user);

            ViewBag.Role = role[0];

            List<SelectListItem> roleList = new List<SelectListItem>();
            var roles = _roleManager.Roles.ToList();
            foreach (var item in roles)
            {
                roleList.Add(new SelectListItem()
                {
                    Text = item.Name,
                    Value = item.Id.ToString()
                });
            }
            ViewBag.Roles = roleList;



            var values = _userManager.Users.Where(x => x.Id == id).FirstOrDefault();
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> UserDetails(AppUser appUser)
        {
            

            var user = await _userManager.FindByIdAsync(appUser.Id.ToString());

            var oldrole = await _roleManager.FindByIdAsync(user.RoleID.ToString());
            await _userManager.RemoveFromRoleAsync(user, oldrole.Name);

            user.RoleID = appUser.RoleID;
            await _userManager.UpdateAsync(user);


            var newrole = await _roleManager.FindByIdAsync(appUser.RoleID.ToString());
            await _userManager.AddToRoleAsync(user, newrole.Name);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> BanUser(int id)
        {

            var user = await _userManager.FindByIdAsync(id.ToString());
            user.Status = false;
            await _userManager.UpdateAsync(user);



            //Log

            _logService.TInsert(new Log()
            {
                LogDescription = $"{user.Name} {user.Surname} isimli kullanıcı {User.Identity.Name} isimli kullanıcı tarafından banlanmıştır.",
                LogDate = DateTime.Now
            });


            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UnbanUser(int id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            user.Status = true;
            await _userManager.UpdateAsync(user);
            

            //Log
            _logService.TInsert(new Log()
            {
                LogDescription = $"{user.Name} {user.Surname} isimli kullanıcının banı {User.Identity.Name} isimli kullanıcı tarafından kaldırılmıştır.",
                LogDate = DateTime.Now
            });

            return RedirectToAction("BannedUserList");
        }
        public IActionResult BannedUserList()
        {
            var value = _userManager.Users.Where(x=>!x.Status).ToList();
            return View(value);
        }

    }
}
