using System.ComponentModel.DataAnnotations;

namespace LessonForum.PresentationLayer.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Bu alan boş bırakılamaz...")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Bu alan boş bırakılamaz...")]
        public string Surname { get; set; }


        [Required(ErrorMessage = "Bu alan boş bırakılamaz...")]
        public string Username { get; set; }


        [Required(ErrorMessage = "Bu alan boş bırakılamaz...")]
        public string Password { get; set; }


        [Required(ErrorMessage = "Bu alan boş bırakılamaz...")]
        [Compare("Password", ErrorMessage = "Şifreler birbiriyle aynı olmalı...")]
        public string ConfirmPassword { get; set; }


        [Required(ErrorMessage = "Bu alan boş bırakılamaz...")]
        public string Mail { get; set; }
    }
}
