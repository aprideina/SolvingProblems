namespace SolvingProblems.Core;

/// <summary>
/// Problem with input and result.
/// </summary>
/// <typeparam name="TInput">Input data type.</typeparam>
/// <typeparam name="TResult">Result type.</typeparam>
public interface ISolvingProblemTaskWithResult<TInput, TResult>
{
    /// <summary>
    /// Run problem.
    /// </summary>
    /// <param name="input">Input parameters.</param>
    /// <returns>Result of function.</returns>
    TResult Run(TInput input);

    /// <summary>
    /// Test cases.
    /// </summary>
    /// <returns>Test cases</returns>
    IEnumerable<TestCasesDto<TInput, TResult>> TestCases();
}