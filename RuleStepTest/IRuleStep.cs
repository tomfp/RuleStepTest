namespace RuleStepTest
{
    public interface IRuleStep
    {
        void SetNextStep(IRuleStep nextStep);
        void ProcessRule(WorkItem workItem);
    }
}
