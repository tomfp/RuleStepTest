namespace RuleStepTest.Rules
{
    public class BuzzRuleStep : RuleStep
    {
        #region Overrides of RuleStep

        public override void ProcessRule(WorkItem workItem)
        {
            if (int.TryParse(workItem.Input, out var result))
            {
                if (result % 5 == 0)
                {
                    workItem.Output.AppendLine("Buzz");
                }
            }
            NextStep?.ProcessRule(workItem);
        }

        #endregion
    }
}
