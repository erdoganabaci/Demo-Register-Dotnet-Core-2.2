using System.ComponentModel.DataAnnotations;

namespace courseApp2.Models
{
    public class Student
    {
        [Required(ErrorMessage = "İsminizi Giriniz.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email adresinizi giriniz")]
        [EmailAddress(ErrorMessage = "Email adresinizi düzgün giriniz!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Telefon Numaranızı giriniz.")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Katılma durumunuz nedir ?")]
        public bool? Confirm { get; set; } //true , false , seçim yoksa null


    }
}