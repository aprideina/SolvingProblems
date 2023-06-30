using System.Collections.Generic;
using SolvingProblems.Core;

namespace SolvingProblems.Arrays;

public class Array1351 : ISolvingProblemTaskWithResult<int[][], int>
{
    public int Run(int[][] input)
    {
        var m = input.GetLength(0);

        var count = 0;
        for (var i = m - 1; i >= 0; i--)
        {
            var n = input[i].Length;
            for (var j = n - 1; j >= 0; j--)
            {
                if (input[i][j] >= 0) break;

                count++;
            }
        }

        return count;
    }

    public IEnumerable<TestCasesDto<int[][], int>> TestCases()
    {
        yield return new TestCasesDto<int[][], int>
        {
            Input = new[]
            {
                new[] {4, 3, 2, -1},
                new[] {3, 2, 1, -1},
                new[] {1, 1, -1, -2},
                new[] {-1, -1, -2, -3}
            },
            Expected = 8
        };

        yield return new TestCasesDto<int[][], int>
        {
            Input = new[]
            {
                new[] {3,2},
                new[] {1,0}
            },
            Expected = 0
        };
    }
}