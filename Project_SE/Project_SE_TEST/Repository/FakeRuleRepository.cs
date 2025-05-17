using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project_SE.Models;
using Project_SE.Repository;

public class FakeRuleRepository : IRuleRepository
{
    private readonly List<Rule> _rules = new List<Rule>();

    public FakeRuleRepository()
    {
        // Seed test data
        _rules.Add(new Rule { RuleID = 1, Title = "Rule 1", Description = "Description 1" });
        _rules.Add(new Rule { RuleID = 2, Title = "Rule 2", Description = "Description 2" });
    }

    public Task<IEnumerable<Rule>> GetAllAsync()
    {
        return Task.FromResult(_rules.AsEnumerable());
    }

    public Task<Rule> GetByIdAsync(int id)
    {
        return Task.FromResult(_rules.FirstOrDefault(r => r.RuleID == id));
    }

    public Task AddAsync(Rule entity)
    {
        _rules.Add(entity);
        return Task.CompletedTask;
    }

    public void Update(Rule entity)
    {
        var existing = _rules.FirstOrDefault(r => r.RuleID == entity.RuleID);
        if (existing != null)
        {
            existing.Title = entity.Title;
            existing.Description = entity.Description;
        }
    }

    public void Delete(Rule entity)
    {
        _rules.Remove(entity);
    }

    public Task SaveAsync()
    {
        return Task.CompletedTask;
    }
}
