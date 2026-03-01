using System;
using System.ComponentModel.DataAnnotations;

namespace CetStudentBook.Models
{
    public class Book
    {
        [Key] // Birincil anahtar (Primary Key) olduğunu belirtir
        public int Id { get; set; }

        [StringLength(200, MinimumLength = 2)]
        [Display(Name = "Book Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Yazar adı zorunludur.")]
        [StringLength(200, MinimumLength = 2)]
        [Display(Name = "Yazar")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Yayın tarihi zorunludur.")]
        [DataType(DataType.Date)]
        [Display(Name = "Yayın Tarihi")]
        public DateTime PublishDate { get; set; }

        [Required(ErrorMessage = "Sayfa sayısı zorunludur.")]
        [Range(1, 10000, ErrorMessage = "Sayfa sayısı 1 ile 10.000 arasında olmalıdır.")]
        [Display(Name = "Sayfa Sayısı")]
        public int PageCount { get; set; }

        [Required]
        [Display(Name = "İkinci El mi?")]
        public bool IsSecondHand { get; set; }
    }
}