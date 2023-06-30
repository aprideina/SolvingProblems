using NUnit.Framework;
using SolvingProblems.Core;

namespace SolvingProblems.Tests;

public abstract class BaseDuoArgumentWithResultTest<T, TInput, TResult>
    where T : IDuoArgumentWithResult<TInput, TResult>, new()
{
    [Test]
    public void Test()
    {
        var task = new T();

        foreach (var testCasesDto in task.TestCases())
        {
            var res = task.Run(testCasesDto.Left, testCasesDto.Right);
            Assert.That(res, Is.EqualTo(testCasesDto.Expected));
        }
    }
}