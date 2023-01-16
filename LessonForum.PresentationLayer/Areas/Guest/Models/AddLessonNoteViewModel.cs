using Microsoft.AspNetCore.Http;

namespace LessonForum.PresentationLayer.Areas.Guest.Models
{
    public class AddLessonNoteViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int SubCategoryID { get; set; }
        public IFormFile LessonFile { get; set; }
    }
}
