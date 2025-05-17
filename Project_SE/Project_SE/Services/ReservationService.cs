// Services/ReservationService.cs
using Project_SE.Interfaces;
using Project_SE.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_SE.Services
{
    public class ReservationService : IReservationService
    {
        private readonly IRepository<Reservation> _reservationRepository;

        public ReservationService(IRepository<Reservation> reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        public async Task<IEnumerable<Reservation>> GetUserReservationsAsync(string userId)
        {
            return (await _reservationRepository.GetAllAsync())
                .Where(r => r.UserId == userId)
                .ToList();
        }

        public async Task<Reservation> GetReservationByIdAsync(int id)
        {
            return (await _reservationRepository.GetAllAsync())
                .FirstOrDefault(r => r.Id == id);
        }

        public async Task<bool> CreateReservationAsync(Reservation reservation)
        {
            await _reservationRepository.AddAsync(reservation);
            return true;
        }

        public async Task<bool> UpdateReservationStatusAsync(int id, string status)
        {
            var reservation = await GetReservationByIdAsync(id);
            if (reservation == null) return false;

            reservation.ReservationStatus = status;
            await _reservationRepository.UpdateAsync(reservation);
            return true;
        }

        public async Task<IEnumerable<Reservation>> GetAllReservationsAsync()
        {
            return await _reservationRepository.GetAllAsync();
        }
    }
}