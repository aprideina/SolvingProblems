namespace SolvingProblems.Core;

public class TestCasesDto<TInput, TResult>
{
    /// <summary>
    /// Input for test case.
    /// </summary>
    public TInput Input { get; set; }
    
    /// <summary>
    /// Expected test result.
    /// </summary>
    public TResult Expected { get; set; }
}