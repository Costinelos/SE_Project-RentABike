using Project_SE.Models;
using Project_SE.Repository;

namespace Project_SE.Services
{
    public interface IRuleService
    {
        Task<IEnumerable<Rule>> GetAllAsync();
        Task<Rule> GetByIdAsync(int id);
        Task AddAsync(Rule rule);
        Task UpdateAsync(Rule rule);
        Task DeleteAsync(int id);
    }
}
