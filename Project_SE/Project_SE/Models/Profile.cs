using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Project_SE.Models;
namespace Project_SE.Models
{
    public class Profile
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        public string AvatarPath { get; set; }

        [StringLength(500)]
        public string Bio { get; set; }

        [Url]
        public string Website { get; set; }

        [StringLength(100)]
        public string Location { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Birthdate { get; set; }
    }
}