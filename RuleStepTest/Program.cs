// See https://aka.ms/new-console-template for more information

using RuleStepTest;
using RuleStepTest.Rules;

Console.WriteLine("Rule Step");


Console.Write("Enter input: ");
var input = Console.ReadLine();

var workItem = new WorkItem(input);

// note: no dependency injection used here, but the classes are designed so DI can be implemented
var firstRule = new FizzRuleStep();
var ruleStack = new FizzBuzzWoof(firstRule,
    new BuzzRuleStep(),
    new WoofRuleStep());

ruleStack.SetNextStep(firstRule);
ruleStack.RunSteps(workItem);

Console.WriteLine(workItem.Output.ToString());

//  go on to process another rule (can continue chain by setting NextStep, but not done here)
var anotherRule = new AnotherRule();

anotherRule.ProcessRule(workItem);

Console.WriteLine(workItem.Output.ToString());

Console.WriteLine("Finished");