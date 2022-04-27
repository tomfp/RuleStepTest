namespace RuleStepTest
{
    public abstract class RuleStep : IRuleStep
    {

        protected IRuleStep? NextStep;
        #region Implementation of IRuleStep

        public virtual void SetNextStep(IRuleStep nextStep)
        {
            NextStep = nextStep;
        }

        public abstract void ProcessRule(WorkItem workItem);

        #endregion
    }
}
