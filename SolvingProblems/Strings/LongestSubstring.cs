using System;
using System.Collections.Generic;
using SolvingProblems.Core;

namespace SolvingProblems.Strings
{
    public class LongestSubstring : ISolvingProblemTaskWithResult<string, int>
    {
        public int Run(string input)
        {
            var indexCharacters = new Dictionary<char, int>(input.Length);
            int left = 0, right = 1, length = 1, maxLength = 1;

            if (input.Length == 0)
            {
                return 0;
            }

            var firstCharacter = input[left];
            indexCharacters[firstCharacter] = 1;
            
            while (right < input.Length)
            {
                var endCharacter = input[right];
                var existKey = indexCharacters.TryGetValue(endCharacter, out var index);

                if (existKey && index > left)
                {
                    maxLength = Math.Max(length, maxLength);

                    left = index;
                    indexCharacters[endCharacter] = right + 1;

                    right++;
                    length = right - left;

                    continue;
                }

                indexCharacters[endCharacter] = right + 1;
                right++;
                length++;
            }

            return Math.Max(length, maxLength);
        }

        public IEnumerable<TestCasesDto<string, int>> TestCases()
        {
            yield return new TestCasesDto<string, int>
            {
                Input = "bbbbb",
                Expected = 1
            };
            yield return new TestCasesDto<string, int>
            {
                Input = "pwwkew",
                Expected = 3
            };
            yield return new TestCasesDto<string, int>
            {
                Input = "abcabcbb",
                Expected = 3
            };
            yield return new TestCasesDto<string, int>
            {
                Input = "abcadef",
                Expected = 6
            };
            yield return new TestCasesDto<string, int>
            {
                Input = "abca",
                Expected = 3
            };
            yield return new TestCasesDto<string, int>
            {
                Input = "aabc",
                Expected = 3
            };
            yield return new TestCasesDto<string, int>
            {
                Input = "aaabcaa",
                Expected = 3
            };
        }
    }
}