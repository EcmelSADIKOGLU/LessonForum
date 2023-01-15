using LessonForum.DataAccessLayer.Migrations;
using LessonForum.EntityLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LessonForum.PresentationLayer.ViewComponents.Layout
{
    public class SidebarComponent:ViewComponent
    {
        
        public IViewComponentResult Invoke()
        {
            if (User.Identity.IsAuthenticated)
            {
                if (User.IsInRole("Admin"))
                {
                    ViewBag.Role = "Admin" ;
                }
                if (User.IsInRole("Üye"))
                {
                    ViewBag.Role = "Üye";
                }
                if (User.IsInRole("Yönetici"))
                {
                    ViewBag.Role = "Yönetici";
                }
            }
            else
            {
                ViewBag.Role = "Ziyaretçi";
            }

            
            return View();
        }
    }
}
