using System.Collections.Generic;

namespace SolvingProblems.Strings
{
	public class StringParentheses20
	{
		private static Dictionary<char, char> Replacement = new Dictionary<char, char>(3)
		{
			{'}', '{'},
			{')', '('},
			{']', '['}
		};

		public bool IsValid(string s)
		{
			var braces = new Stack<char>(s.Length);

			foreach (var ch in s)
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
	}
}