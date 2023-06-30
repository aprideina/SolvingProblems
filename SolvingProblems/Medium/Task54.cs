using System.Collections.Generic;
using SolvingProblems.Core;

namespace SolvingProblems.Medium;

public class Task54 : ISolvingProblemTaskWithResult<int[][], int[]>
{
    public int[] Run(int[][] input)
    {
        var result = new List<int>();

        var vertical = input.Length;
        var horizontal = input[0].Length;

        var shiftV = -1;
        var shiftH = -1;
        for (var v = 0; v < vertical; v++)
        {
            var upper = v % 2 == 0;
            if (upper)
            {
                shiftV++;
                shiftH++;
            }

            for (var h = shiftH; h < horizontal; h++)
                if (upper)
                    result.Add(input[shiftV][h]);
                else
                    result.Add(input[vertical - 1][horizontal - 1 - h - v % 0]);

            for (var v2 = shiftV + 1; v2 < vertical; v2++)
                if (upper)
                {
                    result.Add(input[v2][horizontal - shiftH - 1]);
                }
            //result.Add(matrix[vertical][horizontal - shiftH]);
        }

        return result.ToArray();
    }

    public IEnumerable<TestCasesDto<int[][], int[]>> TestCases()
    {
        yield return new TestCasesDto<int[][], int[]>
        {
            Input = new int[][]
            {
                new int [] { 1,2,3 },
                new int [] { 4,5,6 },
                new int [] { 7,8,9 },
            },
            Expected = new int[] { 1, 2, 3, 6, 9, 8, 7, 4, 5 }
        };
        yield return new TestCasesDto<int[][], int[]>
        {
            Input = new int[][]
            {
                new int [] { 1,2,3,4 },
                new int [] { 5,6,7,8 },
                new int [] { 9,10,11,12 }
            },
            Expected = new int[] { 1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7 }
        };
    }
}