using SolvingProblems.Core.Dtos;

namespace SolvingProblems.Core;

public interface IDuoArgumentWithResult<TInput, TResult>
{
    /// <summary>
    /// Run problem.
    /// </summary>
    /// <param name="left">Input parameters.</param>
    /// <param name="right">Input parameters.</param>
    /// <returns>Result of function.</returns>
    TResult Run(TInput left, TInput right);

    /// <summary>
    /// Test cases.
    /// </summary>
    /// <returns>Test cases</returns>
    IEnumerable<DuoTestCasesDto<TInput, TResult>> TestCases();
}