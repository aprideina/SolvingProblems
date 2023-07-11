using System.Collections.Generic;
using SolvingProblems.Core;

namespace SolvingProblems.Hard;

public class Task135 : ISolvingProblemTaskWithResult<int[], int>
{
    public int Run(int[] ratings) {
            
        var candies = ratings.Length;

        if (ratings.Length == 1)
        {
            return candies;
        }
        
        var count = 1;
        var prevDirection = ratings[0].CompareTo(ratings[1]);
        candies += prevDirection == 1 ? 1 : 0;
        for (var i = 1; i < ratings.Length - 1; i++)
        {
            var direction = ratings[i].CompareTo(ratings[i + 1]);
            
            if (direction == prevDirection)
            {
                if (direction == 0)
                {
                    continue;
                }
                else
                {
                    count++;
                }
            }
            else
            {
                candies += count;
                count = 0;
            }

            prevDirection = direction;
        }
        
        candies += count;

        return candies;
    }

    public IEnumerable<TestCasesDto<int[], int>> TestCases()
    {
        yield return new TestCasesDto<int[], int>
        {
            Input = new[] { 1,3,2,2,1 },
            Expected = 7
        };
        yield return new TestCasesDto<int[], int>
        {
            Input = new[] { 5, 0 },
            Expected = 3
        };
        yield return new TestCasesDto<int[], int>
        {
            Input = new[] { 1 },
            Expected = 1
        };
        yield return new TestCasesDto<int[], int>
        {
            Input = new[] { 0 },
            Expected = 1
        };
        yield return new TestCasesDto<int[], int>
        {
            Input = new[] { 0, 0 },
            Expected = 2
        };
        yield return new TestCasesDto<int[], int>
        {
            Input = new[] { 1,0,2 },
            Expected = 5
        };
        yield return new TestCasesDto<int[], int>
        {
            Input = new[] { 1,2,2 },
            Expected = 4
        };
    }
}