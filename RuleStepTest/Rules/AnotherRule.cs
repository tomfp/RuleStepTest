namespace RuleStepTest.Rules
{
    public class AnotherRule : RuleStep
    {
        #region Overrides of RuleStep

        public override void ProcessRule(WorkItem workItem)
        {
            if (!int.TryParse(workItem.Input, out var _))
            {
                workItem.Output.AppendLine("Pass");
            }
            NextStep?.ProcessRule(workItem);
        }

        #endregion
    }
}
