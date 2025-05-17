using System.ComponentModel.DataAnnotations;

namespace Project_SE.Models
{
    public class Bike
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Modelul este obligatoriu")]
        [StringLength(100, ErrorMessage = "Modelul nu poate depăși 100 de caractere")]
        public string Model { get; set; } = string.Empty;

        [Required(ErrorMessage = "Tipul este obligatoriu")]
        [StringLength(50, ErrorMessage = "Tipul nu poate depăși 50 de caractere")]
        public string Type { get; set; } = string.Empty;

        [Required(ErrorMessage = "Prețul este obligatoriu")]
        [Range(0.01, 10000, ErrorMessage = "Prețul trebuie să fie între 0.01 și 10.000")]
        public decimal Price { get; set; }

        [Required]
        public string Status { get; set; } = "Disponibil";

        [Url(ErrorMessage = "URL-ul imaginii nu este valid")]
        [Display(Name = "URL Imagine")]
        public string ImageUrl { get; set; } = string.Empty;

        [StringLength(500, ErrorMessage = "Descrierea nu poate depăși 500 de caractere")]
        public string Description { get; set; } = string.Empty;
    }
}