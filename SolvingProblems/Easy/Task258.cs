using System;
using System.Collections.Generic;
using SolvingProblems.Core;

namespace SolvingProblems.Easy;

public class Task258 : ISolvingProblemTaskWithResult<int, int>
{
    private const int V = 10;

    private int Sum(int i, int j)
    {
        var res = i + j;
        if (res >= V) return Sum(res / V, res % V);

        return res;
    }

    public int Run(int input)
    {
        
        if (input < V) return input;

        var length = input.ToString().Length;
        while (length != 1)
        {
            var firstPow = (int)Math.Pow(V, length - 1);
            var secondPow = (int)Math.Pow(V, length - 2);

            var f = input / firstPow;
            var s = (input - f * firstPow) / secondPow;
            var sum = Sum(f, s);

            input -= f * firstPow + s * secondPow;
            input += sum * secondPow;

            length--;
        }

        return input;
    }

    public IEnumerable<TestCasesDto<int, int>> TestCases()
    {
        yield return new TestCasesDto<int, int>
        {
            Input = 38,
            Expected = 2
        };
        yield return new TestCasesDto<int, int>
        {
            Input = 111,
            Expected = 3
        };
        yield return new TestCasesDto<int, int>
        {
            Input = 19,
            Expected = 1
        };
        yield return new TestCasesDto<int, int>
        {
            Input = 199,
            Expected = 1
        };
        yield return new TestCasesDto<int, int>
        {
            Input = 0,
            Expected = 0
        };
    }
}