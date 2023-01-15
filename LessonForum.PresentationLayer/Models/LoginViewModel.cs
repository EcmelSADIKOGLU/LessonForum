using System.ComponentModel.DataAnnotations;

namespace LessonForum.PresentationLayer.Models
{
    public class LoginViewModel
    {

        [Required(ErrorMessage = "Bu alan boş bırakılamaz...")]
        public string Username { get; set; }


        [Required(ErrorMessage = "Bu alan boş bırakılamaz...")]
        public string Password { get; set; }
        
    }
}
