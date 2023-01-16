using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonForum.EntityLayer.Entities
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }
        public string SenderMail { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
    }
}
