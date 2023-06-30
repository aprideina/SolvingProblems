using System.Collections.Generic;
using SolvingProblems.Core;

namespace SolvingProblems.Medium;

public class Task649 : ISolvingProblemTaskWithResult<string, string>
{
    private const string Dire = "Dire";
    private const string Radiant = "Radiant";

    public string Run(string input)
    {
        var queue = new Queue<char>(input.ToCharArray());

        var step = 0;
        while (queue.Count != 1)
        {
            var index = 1;
            var dict = new Dictionary<char, int>
            {
                { 'R', 0 },
                { 'D', 0 }
            };

            var newQueue = new Queue<char>();
            foreach (var item in queue)
                if (index++ % 2 != step)
                {
                    newQueue.Enqueue(item);
                    dict[item]++;
                }

            queue = newQueue;

            step = step == 1 ? 1 : 0;
        }

        var last = queue.Dequeue();
        return last == 'R' ? "Radiant" : Dire;
    }

    public IEnumerable<TestCasesDto<string, string>> TestCases()
    {
        yield return new TestCasesDto<string, string>
        {
            Input = "RD",
            Expected = "Radiant"
        };
        yield return new TestCasesDto<string, string>
        {
            Input = "RDD",
            Expected = "Dire"
        };
        yield return new TestCasesDto<string, string>
        {
            Input = "DDR",
            Expected = "Dire"
        };
    }
}