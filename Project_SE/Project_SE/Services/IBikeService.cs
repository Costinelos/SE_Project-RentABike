using Project_SE.Models;

namespace Project_SE.Interfaces
{
    public interface IBikeService
    {
        Task<IEnumerable<Bike>> GetAllBikesAsync();
        Task<Bike> GetBikeByIdAsync(int id);
        Task AddBikeAsync(Bike bike);
        Task UpdateBikeAsync(Bike bike);
        Task DeleteBikeAsync(int id);
    }
}