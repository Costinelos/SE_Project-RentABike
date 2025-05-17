using System.ComponentModel.DataAnnotations;

namespace Project_SE.Models
{
    public class Rule
    {
        [Key]
        public int RuleID { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
