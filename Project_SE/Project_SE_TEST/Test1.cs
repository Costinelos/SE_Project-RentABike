using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_SE.Models;
using Project_SE.Services;
using System.Linq;
using System.Threading.Tasks;

namespace Project_SE.Tests
{
    [TestClass]
    public class RuleServiceTests
    {
        private RuleService _ruleService;

        [TestInitialize]
        public void Setup()
        {
            var fakeRepository = new FakeRuleRepository();
            _ruleService = new RuleService(fakeRepository);
        }

        [TestMethod]
        public async Task GetAllAsync_ReturnsAllRules()
        {
            // Act
            var rules = await _ruleService.GetAllAsync();

            // Assert
            Assert.IsNotNull(rules);
            Assert.AreEqual(2, rules.Count());
            Assert.IsTrue(rules.Any(r => r.Title == "Rule 1"));
            Assert.IsTrue(rules.Any(r => r.Title == "Rule 2"));
        }
    }
}
