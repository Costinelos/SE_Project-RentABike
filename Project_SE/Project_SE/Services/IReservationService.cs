// Interfaces/IReservationService.cs
using Project_SE.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project_SE.Interfaces
{
    public interface IReservationService
    {
        Task<IEnumerable<Reservation>> GetUserReservationsAsync(string userId);
        Task<Reservation> GetReservationByIdAsync(int id);
        Task<bool> CreateReservationAsync(Reservation reservation);
        Task<bool> UpdateReservationStatusAsync(int id, string status);
        Task<IEnumerable<Reservation>> GetAllReservationsAsync();
    }
}