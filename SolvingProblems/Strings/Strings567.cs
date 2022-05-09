using System.Collections.Generic;
using System.Linq;

namespace SolvingProblems.Strings
{
	public class Strings567
	{
		public bool CheckInclusion(string s1, string s2)
		{
			if (s1.Intersect(s2).Count() != s1.Length) return false;

			var dictSubstring = new Dictionary<char, bool[]>();
			for (var i = 0; i < s1.Length; i++)
			{
				var key = s1[i];

				if (!dictSubstring.ContainsKey(key))
				{
					var value = new bool[10000];
					dictSubstring.Add(key, value);
				}
				dictSubstring[key][i] = true;
			}

			var dictSearch = new Dictionary<char, bool[]>();
			for (var i = 0; i < s2.Length; i++)
			{
				var key = s2[i];
				if (!dictSubstring.ContainsKey(key))
				{
					continue;
				}

				if (!dictSearch.ContainsKey(key))
				{
					var value = new bool[10000];
					dictSearch.Add(key, value);
				}
				dictSearch[key][i] = true;
			}

			foreach (var tp in dictSubstring)
			{
				
			}

			return true;
		}
	}
}