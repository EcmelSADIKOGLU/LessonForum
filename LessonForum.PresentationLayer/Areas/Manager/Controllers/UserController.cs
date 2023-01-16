using LessonForum.BusinessLayer.Abstract;
using LessonForum.EntityLayer.Entities;
using LessonForum.PresentationLayer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace LessonForum.PresentationLayer.Areas.Manager.Controllers
{
    [Area("Manager")]
    [Route("Manager/User")]
    [Authorize(Roles = "Yönetici")]
    public class UserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly ILogService _logService;

        public UserController(UserManager<AppUser> userManager, ILogService logService, RoleManager<AppRole> roleManager)
        {
            _userManager = userManager;
            _logService = logService;
            _roleManager = roleManager;
        }

        [Route("")]
        [Route("Index")]
        public async Task<IActionResult> Index()
        {

            var values = _userManager.Users.Where(x => x.Status).ToList();

            List<UserListWithRoleModel> userList = new List<UserListWithRoleModel>();
            foreach (var item in values)
            {
                var user = await _userManager.FindByIdAsync(item.Id.ToString());
                var role = await _userManager.GetRolesAsync(user);

                if (role[0] == "Üye")
                {
                    userList.Add(new UserListWithRoleModel
                    {
                        Id = item.Id,
                        Name = item.Name,
                        Surname = item.Surname,
                        Role = role[0],
                        Status = item.Status
                    });
                }           
            }
            return View(userList);
        }


        [Route("")]
        [Route("BanUser/{id}")]
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

        [Route("")]
        [Route("UnbanUser/{id}")]
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

        [Route("")]
        [Route("BannedUserList")]
        public IActionResult BannedUserList()
        {
            var value = _userManager.Users.Where(x => !x.Status).ToList();
            return View(value);
        }
    }
}
