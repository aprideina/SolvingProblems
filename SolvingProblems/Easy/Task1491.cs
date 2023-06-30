using System;
using System.Collections.Generic;
using SolvingProblems.Core;

namespace SolvingProblems.Easy;

public class Task1491 : ISolvingProblemTaskWithResult<int[], double>
{
    public double Run(int[] input)
    {
        int min = 1000001, max = 0;
        double sum = 0;
        foreach (var s in input)
        {
            min = Math.Min(s, min);
            max = Math.Max(s, max);
            sum += s;
        }

        var v = (sum - min - max) / (input.Length - 2);
        return Math.Round(v, 5);
    }

    public IEnumerable<TestCasesDto<int[], double>> TestCases()
    {
        yield return new TestCasesDto<int[], double>
        {
            Input = new[] { 4000, 3000, 1000, 2000 },
            Expected = 2500.00000
        };
        yield return new TestCasesDto<int[], double>
        {
            Input = new[] { 1000, 2000, 3000 },
            Expected = 2000.00000
        };
        yield return new TestCasesDto<int[], double>
        {
            Input = new[]
            {
                48000, 59000, 99000, 13000, 78000, 45000, 31000, 17000, 39000, 37000, 93000, 77000, 33000, 28000, 4000,
                54000, 67000, 6000, 1000, 11000
            },
            Expected = 41111.11111
        };
    }
}