namespace RuleStepTest.Rules
{
    public class WoofRuleStep : RuleStep
    {
        public override void ProcessRule(WorkItem workItem)
        {
            if (int.TryParse(workItem.Input, out var result))
            {
                if (result%7==0)
                {
                    workItem.Output.AppendLine("Woof");
                }
            }
            NextStep?.ProcessRule(workItem);
        }
    }
}
