using System;
using System.Collections.Generic;

namespace SolvingProblems.Strings
{
	public class Strings3
	{
		public int LengthOfLongestSubstring(string s)
		{
			var dict = new Dictionary<char, int>(s.Length);
			int left = 0, right = 0, maxLength = 0;
			foreach (var ch in s)
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
	}
}