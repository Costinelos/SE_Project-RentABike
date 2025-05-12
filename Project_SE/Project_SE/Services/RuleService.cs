using Project_SE.Repository;
using Project_SE.Models;

namespace Project_SE.Services
{
    public class RuleService : IRuleService
    {
        private readonly IRuleRepository _repository;

        public RuleService(IRuleRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Rule>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Rule> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task AddAsync(Rule rule)
        {
            await _repository.AddAsync(rule);
            await _repository.SaveAsync();
        }

        public async Task UpdateAsync(Rule rule)
        {
            _repository.Update(rule);
            await _repository.SaveAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var rule = await _repository.GetByIdAsync(id);
            if (rule != null)
            {
                _repository.Delete(rule);
                await _repository.SaveAsync();
            }
        }
    }
}
