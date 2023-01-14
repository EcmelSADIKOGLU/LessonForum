using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonForum.EntityLayer.Entities
{
    public class LessonNote
    {
        [Key]
        public int LessonNotesID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string FileName { get; set; }
        public bool Status { get; set; }
        public bool Deleted { get; set; }
        

        //SubCategory Relation
        public SubCategory SubCategory { get; set; }
        public int SubCategoryID { get; set; }

        //User Relation
        public AppUser AppUser { get; set; }

    }
}
