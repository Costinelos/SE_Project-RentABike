using Project_SE.Models;
public interface IProfileRepository
{
    Task<Profile> GetByIdAsync(int id);
    Task<Profile> GetByUserIdAsync(string userId);
    Task<IEnumerable<Profile>> GetAllAsync();
    Task AddAsync(Profile profile);
    Task UpdateAsync(Profile profile);
    Task DeleteAsync(int id);
}
