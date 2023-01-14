using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonForum.EntityLayer.Entities
{
    public class AppRole:IdentityRole<int>
    {
        public bool Status { get; set; }

        //public List<AppUser> AppUsers { get; set; }
    }
}
