using System.Text;

namespace RuleStepTest
{
    public class WorkItem
    {
        public WorkItem(string? input)
        {
            Input = input;
            Output = new StringBuilder();
        }
        public string? Input { get; private set; }
        public StringBuilder Output { get; private set; }
    }
}
