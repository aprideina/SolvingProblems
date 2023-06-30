namespace SolvingProblems.Core.Dtos;

public class DuoTestCasesDto<TInput, TResult>
{
    /// <summary>
    /// Input for test case.
    /// </summary>
    public TInput Left { get; set; }

    /// <summary>
    /// Input for test case.
    /// </summary>
    public TInput Right { get; set; }
    
    /// <summary>
    /// Expected test result,
    /// </summary>
    public TResult Expected { get; set; }
}