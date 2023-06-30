using System.Collections.Generic;
using SolvingProblems.Core;

namespace SolvingProblems.Strings
{
	public class StringParentheses20 : ISolvingProblemTaskWithResult<string, bool>
	{
		private static readonly Dictionary<char, char> Replacement = new(3)
		{
			{'}', '{'},
			{')', '('},
			{']', '['}
		};

		public bool Run(string input)
		{
			var braces = new Stack<char>(input.Length);

			foreach (var ch in input)
				switch (ch)
				{
					case '{':
					case '[':
					case '(':
						braces.Push(ch);
						break;
					default:
						if (braces.Count == 0) return false;

						var last = braces.Pop();
						if (last != Replacement[ch]) return false;

						break;
				}

			return braces.Count == 0;
		}

		public IEnumerable<TestCasesDto<string, bool>> TestCases()
		{
			yield return new TestCasesDto<string, bool>
			{
				Input = "()",
				Expected = true
			};
			yield return new TestCasesDto<string, bool>
			{
				Input = "()[]{}",
				Expected = true
			};
			yield return new TestCasesDto<string, bool>
			{
				Input = "(]",
				Expected = false
			};
			yield return new TestCasesDto<string, bool>
			{
				Input = "(",
				Expected = false
			};
		}
	}
}