using System;
using System.Linq;
using NUnit.Framework;
using SolvingProblems.Core;

namespace SolvingProblems.Tests;

public abstract class BaseTest<T, TInput, TResult>
    where T : ISolvingProblemTaskWithResult<TInput, TResult>, new()
{
    [Test]
    public void Test()
    {
        var task = new T();

        foreach (var testCasesDto in task.TestCases())
        {
            var res = task.Run(testCasesDto.Input);
            Assert.That(res, Is.EqualTo(testCasesDto.Expected), message: GetMessage(testCasesDto.Input));
        }
    }

    private string GetMessage(TInput input)
    {
        switch (input)
        {
            case int[] arr:
            {
                return string.Join(',', arr.Select(i => i.ToString()));
            }
        }

        return input.ToString();
    }
}