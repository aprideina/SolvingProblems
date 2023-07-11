using System;
using System.Collections.Generic;
using SolvingProblems.Core;

namespace SolvingProblems.Medium;

public class Task1493 : ISolvingProblemTaskWithResult<int[], int>
{
    public int Run(int[] nums)
    {
        var currentLenght = 0;
        var prevLenght = 0;
        var max = 0;
        var prevSymbol = -1;
        for (var i = 0; i < nums.Length; i++)
        {
            var current = nums[i];
            if (current == 0)
            {
                max = Math.Max(max, prevLenght + currentLenght);
                prevLenght = currentLenght;
                currentLenght = 0;
            }
            else if (current == 1)
            {
                currentLenght++;
            }

            if (prevSymbol == 0 && current == 0)
            {
                prevLenght = 0;
            }

            prevSymbol = current;
        }
        max = Math.Max(max, prevLenght + currentLenght);
        return max == nums.Length ? max - 1 : max;
    }

    public IEnumerable<TestCasesDto<int[], int>> TestCases()
    {
        yield return new TestCasesDto<int[], int>
        {
            Input = new[] { 1 },
            Expected = 0
        };
        yield return new TestCasesDto<int[], int>
        {
            Input = new[] { 0 },
            Expected = 0
        };
        yield return new TestCasesDto<int[], int>
        {
            Input = new[] { 1,0,1,1,1,1,1,0,1,0,1,1,1,0,1,1,1,1,1,1,1,1,1,0,1,1,1,1,1,1,0,1,0,1,1,1,1,1,1,1,1,1,1,1 },
            Expected = 15
        };
        yield return new TestCasesDto<int[], int>
        {
            Input = new[] { 1,1,0,1 },
            Expected = 3
        };
        yield return new TestCasesDto<int[], int>
        {
            Input = new[] { 0,1,1,1,0,1,1,0,1 },
            Expected = 5
        };
        yield return new TestCasesDto<int[], int>
        {
            Input = new[] { 0,0,0 },
            Expected = 0
        };
        yield return new TestCasesDto<int[], int>
        {
            Input = new[] { 1,1,1 },
            Expected = 2
        };
        yield return new TestCasesDto<int[], int>
        {
            Input = new[] { 1,0,1,0,1,0 },
            Expected = 2
        };
    }
}