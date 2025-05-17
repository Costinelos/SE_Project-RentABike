using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_SE.Models
{
    public class Reservation
    {
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        [Required]
        public int BikeId { get; set; }

        [ForeignKey("BikeId")]
        public virtual Bike Bike { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Reservation Status")]
        public string ReservationStatus { get; set; } = "Pending"; // Pending, Approved, Rejected

        [Display(Name = "Payment Status")]
        public string PaymentStatus { get; set; } = "Unpaid"; // Unpaid, Pending, Completed, Failed

        [Display(Name = "Total Price")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalPrice { get; set; }

        [Display(Name = "Payment Date")]
        public DateTime? PaymentDate { get; set; }

        [Display(Name = "Transaction ID")]
        public string? TransactionId { get; set; }

        [Display(Name = "Request Date")]
        public DateTime RequestDate { get; set; } = DateTime.Now;

        [Display(Name = "Admin Notes")]
        public string? AdminNotes { get; set; }
    }
}