namespace RuleStepTest.Rules
{
    public class FizzRuleStep : RuleStep
    {
        public override void ProcessRule(WorkItem workItem)
        {
            if (int.TryParse(workItem.Input, out var result))
            {
                if (result % 3 == 0)
                {
                    workItem.Output.AppendLine("Fizz");
                }
            }
            NextStep?.ProcessRule(workItem);
        }
    }
}
