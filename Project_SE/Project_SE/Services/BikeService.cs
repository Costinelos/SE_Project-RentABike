using Project_SE.Interfaces;
using Project_SE.Models;
using Project_SE.Repository;

namespace Project_SE.Services
{
    public class BikeService : IBikeService
    {
        private readonly IRepository<Bike> _bikeRepository;

        public BikeService(IRepository<Bike> bikeRepository)
        {
            _bikeRepository = bikeRepository;
        }

        public async Task<IEnumerable<Bike>> GetAllBikesAsync()
        {
            return await _bikeRepository.GetAllAsync();
        }

        public async Task<Bike> GetBikeByIdAsync(int id)
        {
            return await _bikeRepository.GetByIdAsync(id);
        }

        public async Task AddBikeAsync(Bike bike)
        {
            await _bikeRepository.AddAsync(bike);
        }

        public async Task UpdateBikeAsync(Bike bike)
        {
            await _bikeRepository.UpdateAsync(bike);
        }

        public async Task DeleteBikeAsync(int id)
        {
            await _bikeRepository.DeleteAsync(id);
        }
    }
}