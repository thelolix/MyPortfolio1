using System.ComponentModel.DataAnnotations;

namespace MYAcedemy_Portfolio_Project.Entites
{
    public class Message
    {
        [Key]
        public int MessageID { get; set; }

        [Required(ErrorMessage = "Ad Soyad Boş Gecilmez")]
        public string NameSurname { get; set; }


        [Required(ErrorMessage = "E-posta alanı boş bırakılamaz.")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Konu alanı boş bırakılamaz.")]
        public string Subject { get; set; }


        [Required(ErrorMessage = "Mesaj alanı boş bırakılamaz.")]
        public string MessageDetail { get; set; }
       
        
        public DateTime SendDate { get; set; }

        public bool IsRead { get; set; }
    }
}
