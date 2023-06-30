using System.Collections.Generic;
using SolvingProblems.Core;

namespace SolvingProblems.Easy;

public class Task1822 : ISolvingProblemTaskWithResult<int[], int>
{
    public int Run(int[] input)
    {
        var res = false;
        foreach (var n in input)
        {
            if (n == 0) return 0;
            res ^= n < 0;
        }

        return res ? -1 : 1;
    }

    public IEnumerable<TestCasesDto<int[], int>> TestCases()
    {
        yield return new TestCasesDto<int[], int>
        {
            Input = new[] { -1, -2, -3, -4, 3, 2, 1 },
            Expected = 1
        };
        yield return new TestCasesDto<int[], int>
        {
            Input = new[] { 1, 5, 0, 2, -3 },
            Expected = 0
        };
        yield return new TestCasesDto<int[], int>
        {
            Input = new[] { -1, 1, -1, 1, -1 },
            Expected = -1
        };
    }
}