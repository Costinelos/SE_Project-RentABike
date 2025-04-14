namespace Project_SE.Models
{
    public class Bike
    {
        public int Id { get; set; }
        public string Model { get; set; } = string.Empty; // Evită warning-uri
        public string Type { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Status { get; set; } = "Disponibil"; // Valoare implicită
    }
}