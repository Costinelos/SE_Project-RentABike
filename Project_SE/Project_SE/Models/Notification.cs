using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

public class Notification
{
    public int Id { get; set; }

    [Required]
    public string Message { get; set; }

    [Required]
    public string UserId { get; set; }

    public bool IsRead { get; set; } = false;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

   
    public virtual User User { get; set; }
}