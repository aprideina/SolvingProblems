using System.Collections.Generic;
using SolvingProblems.Core;

namespace SolvingProblems.Arrays;

public class Array1046 : ISolvingProblemTaskWithResult<int[], int>
{
    public int Run(int[] input)
    {
        var length = 1001;
        var indexes = new int[length];
        var max = 3;
        foreach (var st in input)
        {
            indexes[st]++;
            max = max > st ? max : st + 1;
        }

        var r = max - 1;
        var l = max - 2;

        do
        {
            if (indexes[r] == 0) r--;

            if (indexes[l] == 0) l--;

            if (l == r) l--;

            if (indexes[l] > 0 && indexes[r] > 0)
            {
                indexes[r] = indexes[r] % 2;
                while (indexes[r] > 0)
                {
                    var result = r - l;
                    indexes[l]--;
                    indexes[r]--;

                    indexes[result]++;
                    l = l > result ? l : result;
                }

                r--;
            }
        } while (l > 0);

        indexes[r] %= 2;
        return indexes[r] == 0 ? 0 : r;
    }

    public IEnumerable<TestCasesDto<int[], int>> TestCases()
    {
        yield return new TestCasesDto<int[], int>
        {
            Input = new[]{2, 7, 4, 1, 8, 1 },
            Expected = 1
        };
        yield return new TestCasesDto<int[], int>
        {
            Input = new[]{1},
            Expected = 1
        };
        yield return new TestCasesDto<int[], int>
        {
            Input = new[]{1, 3},
            Expected = 2
        };
        yield return new TestCasesDto<int[], int>
        {
            Input = new[]{2, 2},
            Expected = 0
        };
        yield return new TestCasesDto<int[], int>
        {
            Input = new[]{3, 7, 2},
            Expected = 2
        };
        yield return new TestCasesDto<int[], int>
        {
            Input = new[]{7,6,7,6,9},
            Expected = 3
        };
        yield return new TestCasesDto<int[], int>
        {
            Input = new[]{9,3,2,10},
            Expected = 0
        };
        yield return new TestCasesDto<int[], int>
        {
            Input = new[]{9,3,2,10},
            Expected = 0
        };
        yield return new TestCasesDto<int[], int>
        {
            Input = new[]{4,3,4,3,2},
            Expected = 2
        };
    }
}