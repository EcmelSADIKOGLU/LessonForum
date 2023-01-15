using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonForum.EntityLayer.Entities
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public bool Deleted { get; set; }

        //subCategory relation
        public List<SubCategory> subCategories { get; set; }
    }
}
