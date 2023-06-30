using System;
using System.Collections.Generic;
using SolvingProblems.Core;

namespace SolvingProblems.Strings
{
	public class Strings3 : ISolvingProblemTaskWithResult<string, int>
	{
		public int Run(string input)
		{
			var dict = new Dictionary<char, int>(input.Length);
			int left = 0, right = 0, maxLength = 0;
			foreach (var ch in input)
			{
				if (dict.ContainsKey(ch))
				{
					var i = dict[ch];

					if (i >= left)
					{
						var len = right - left;
						maxLength = Math.Max(len, maxLength);

						left = i + 1;
					}
					dict[ch] = right;
				}
				else
				{
					dict.Add(ch, right);
				}

				right++;
			}

			return Math.Max(maxLength, right - left);
		}

		public IEnumerable<TestCasesDto<string, int>> TestCases()
		{
			yield return new TestCasesDto<string, int>
			{
				Input = "abcabcbb",
				Expected = 3
			};
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
				Input = "bbbbb",
				Expected = 1
			};
			yield return new TestCasesDto<string, int>
			{
				Input = "",
				Expected = 0
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
				Input = "abcaabcd",
				Expected = 4
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