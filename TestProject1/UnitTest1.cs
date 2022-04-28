using Microsoft.VisualStudio.TestTools.UnitTesting;
using RuleStepTest;
using RuleStepTest.Rules;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow(null, false)]
        [DataRow("2", false)]
        [DataRow("3", true)]
        [DataRow("27", true)]
        public void TestFizzRule(string input, bool expectedResult)
        {
            var workItem = new WorkItem(input);
            var rule = new FizzRuleStep();
            rule.ProcessRule(workItem);
            var actualResult = workItem.Output.ToString().Contains("Fizz");
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}