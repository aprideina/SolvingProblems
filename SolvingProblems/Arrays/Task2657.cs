using System.Collections.Generic;
using SolvingProblems.Core;
using SolvingProblems.Core.Dtos;

namespace SolvingProblems.Arrays;

public class Task2657 : IDuoArgumentWithResult<int[], int[]>
{
    public int[] Run(int[] A, int[] B)
    {
        var indexes = new int[51];
        var n = A.Length;
        var result = new int[n];
        for (var i = 0; i < n; i++)
        {
            var leftValue = A[i];
            var rightValue = B[i];

            var prevValue = i != 0 ? result[i - 1] : 0;
            if (leftValue == rightValue)
            {
                result[i] = 1 + prevValue;
                continue;
            }
            
            indexes[leftValue]++;
            indexes[rightValue]++;

            var sameLeftValue = indexes[leftValue]/2;
            var sameRightValue = indexes[rightValue]/2;
            result[i] = sameLeftValue + sameRightValue + prevValue;
        }

        return result;
    }

    public IEnumerable<DuoTestCasesDto<int[], int[]>> TestCases()
    {
        yield return new DuoTestCasesDto<int[], int[]>
        {
            Left = new[] { 1, 3, 2, 4 },
            Right = new[] { 3, 1, 2, 4 },
            Expected = new[] { 0, 2, 3, 4 }
        };
        yield return new DuoTestCasesDto<int[], int[]>
        {
            Left = new[] { 2,3,1 },
            Right = new[] { 3,1,2 },
            Expected = new[] { 0,1,3 }
        };
        yield return new DuoTestCasesDto<int[], int[]>
        {
            Left = new[] { 1 },
            Right = new[] { 2 },
            Expected = new[] { 0 }
        };
        yield return new DuoTestCasesDto<int[], int[]>
        {
            Left = new[] { 1, 2, 3 },
            Right = new[] { 3, 2, 1 },
            Expected = new[] { 0, 1, 3 }
        };
    }
}