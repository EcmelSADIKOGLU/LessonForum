using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonForum.EntityLayer.Entities
{
    public class AppUser:IdentityUser<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool Status { get; set; }
        public bool Deleted { get; set; }
        public int RoleID { get; set; }
        //public AppRole AppRole { get; set; }

        //LessonNotes Relation
        public List<LessonNote> LessonNotes { get; set; }

        //SubCategory Relation
        public List<SubCategory> SubCategory { get; set; }


    }
}
