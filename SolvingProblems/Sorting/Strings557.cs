using System.Collections.Generic;
using SolvingProblems.Core;

namespace SolvingProblems.Sorting;

public class Strings557 : ISolvingProblemTaskWithResult<string, string>
{
    public string Run(string input)
    {
        var charArray = input.ToCharArray();
        var left = 0;
        var right = 0;
        while (right != input.Length)
        {
            var c = charArray[right];
            if (c == ' ')
            {
                SubArray(charArray, left, right);
                left = right + 1;
            }

            right++;
        }

        SubArray(charArray, left, right);

        return new string(charArray);
    }

    public IEnumerable<TestCasesDto<string, string>> TestCases()
    {
        yield return new TestCasesDto<string, string>
        {
            Input = "Let's take LeetCode contest",
            Expected = "s'teL ekat edoCteeL tsetnoc"
        };
        yield return new TestCasesDto<string, string>
        {
            Input = "God Ding",
            Expected = "doG gniD"
        };
    }

    private static void SubArray(char[] s, int left, int right)
    {
        var groups = (right - left) / 2;

        for (var i = 0; i < groups; i++)
        {
            var start = left + i;
            var end = right - 1 - i;

            var buf = s[start];
            s[start] = s[end];
            s[end] = buf;
        }
    }
}