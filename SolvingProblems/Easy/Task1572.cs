using System.Collections.Generic;
using SolvingProblems.Core;

namespace SolvingProblems.Easy;

public class Task1572 : ISolvingProblemTaskWithResult<int[][], int>
{
    public int Run(int[][] input)
    {
        var sum = 0;
        if (input.Length == 1) return input[0][0];

        for (var i = 0; i < input.Length; i++)
        {
            sum += input[i][i];

            var v = input.Length - 1 - i;
            if (v != i) sum += input[v][i];
        }

        return sum;
    }

    public IEnumerable<TestCasesDto<int[][], int>> TestCases()
    {
        yield return new TestCasesDto<int[][], int>
        {
            Input = new[]
            {
                new[] { 1,2,3 },
                new[] { 4,5,6 },
                new[] { 7,8,9 },
            },
            Expected = 25
        };
        yield return new TestCasesDto<int[][], int>
        {
            Input = new[]
            {
                new[] { 1,1,1,1 },
                new[] { 1,1,1,1 },
                new[] { 1,1,1,1 },
                new[] { 1,1,1,1 },
            },
            Expected = 8
        };

        yield return new TestCasesDto<int[][], int>
        {
            Input = new[]
            {
                new[] { 5 },
            },
            Expected = 5
        };
    }
}