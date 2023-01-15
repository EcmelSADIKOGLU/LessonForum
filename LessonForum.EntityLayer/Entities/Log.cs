using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonForum.EntityLayer.Entities
{
    public class Log
    {
        [Key]
        public int LogID { get; set; }
        public string LogDescription { get; set; }
        public DateTime LogDate{ get; set; }
    }
}
