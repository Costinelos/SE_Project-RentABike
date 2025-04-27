using Microsoft.AspNetCore.Mvc;
using Project_SE.Models;
using System;
using System.ComponentModel.DataAnnotations;

public class Reservation
{
    public int Id { get; set; }

    [Required]
    public string UserId { get; set; }

    [Required]
    public int BikeId { get; set; }

    [Required]
    public DateTime StartDate { get; set; }

    [Required]
    public DateTime EndDate { get; set; }

    [Required]
    public string PaymentStatus { get; set; } = "Pending"; // Pending, Completed, Failed

    public decimal TotalPrice { get; set; }


    public virtual Bike Bike { get; set; }
    public virtual User User { get; set; }
}
