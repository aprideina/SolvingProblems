using System;
using System.Collections.Generic;
using SolvingProblems.Core;

namespace SolvingProblems.Medium;

public class Task319 : ISolvingProblemTaskWithResult<int, int>
{
    public int Run(int input)
    {
        var t = (int)Math.Sqrt(input);
        return t;
    }

    public IEnumerable<TestCasesDto<int, int>> TestCases()
    {
        yield return new TestCasesDto<int, int>()
        {
            Input = 0,
            Expected = 0
        };
        yield return new TestCasesDto<int, int>()
        {
            Input = 1,
            Expected = 1
        };
        yield return new TestCasesDto<int, int>()
        {
            Input = 3,
            Expected = 1
        };
        yield return new TestCasesDto<int, int>()
        {
            Input = 4,
            Expected = 2
        };
        yield return new TestCasesDto<int, int>()
        {
            Input = 5,
            Expected = 2
        };
        yield return new TestCasesDto<int, int>()
        {
            Input = 6,
            Expected = 2
        };
    }
}