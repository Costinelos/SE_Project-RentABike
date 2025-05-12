using Project_SE;
using Project_SE.Models;
using Project_SE.Data;
using Project_SE.Repository;

namespace Project_SE.Repository
{
    public class RuleRepository : GenericRepository<Rule>, IRuleRepository
    {
        public RuleRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
