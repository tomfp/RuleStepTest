using RuleStepTest.Rules;
namespace RuleStepTest
{
    public class FizzBuzzWoof : IFizzBuzzWoof
    {
        private readonly FizzRuleStep _fizzRuleStep;
        private readonly BuzzRuleStep _buzzRuleStep;
        private readonly WoofRuleStep _woofRuleStep;

        public FizzBuzzWoof(FizzRuleStep fizzRuleStep,
            BuzzRuleStep buzzRuleStep,
            WoofRuleStep woofRuleStep)
        {
            _fizzRuleStep = fizzRuleStep;
            _buzzRuleStep = buzzRuleStep;
            _woofRuleStep = woofRuleStep;
        }
        #region Implementation of IFizzBuzzWoof

        public void SetNextStep(RuleStep nextStep)
        {
            _fizzRuleStep.SetNextStep(_buzzRuleStep);
            _buzzRuleStep.SetNextStep(_woofRuleStep);
        }

        #endregion

        public void RunSteps(WorkItem workItem)
        {
            _fizzRuleStep.ProcessRule(workItem);
        }
    }
}
