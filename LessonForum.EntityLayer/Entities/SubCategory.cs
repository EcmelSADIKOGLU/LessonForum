using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonForum.EntityLayer.Entities
{
    public class SubCategory
    {
        [Key]
        public int SubCategoryID { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public bool Deleted { get; set; }

        //Category Relation
        public int CategoryID { get; set; }
        public Category Category { get; set; }

        //LessonNotes Relation
        public List<LessonNote> LessonNotes { get; set; }
        
        //User Relation
        public AppUser AppUser { get; set; }


    }
}
