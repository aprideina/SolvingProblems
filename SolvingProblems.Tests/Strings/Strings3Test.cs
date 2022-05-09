using NUnit.Framework;
using SolvingProblems.Strings;

namespace SolvingProblems.Tests.Strings
{
	public class Strings3Test
	{
		private readonly Strings3 _sut = new Strings3();

		[Theory]
		[TestCase("abcabcbb", 3)]
		[TestCase("bbbbb", 1)]
		[TestCase("pwwkew", 3)]
		[TestCase("bbbbb", 1)]
		[TestCase("", 0)]
		[TestCase("pwwkew", 3)]
		[TestCase("abcabcbb", 3)]
		[TestCase("abcaabcd", 4)]
		[TestCase("abcadef", 6)]
		[TestCase("abca", 3)]
		[TestCase("aabc", 3)]
		[TestCase("aaabcaa", 3)]
		public void Test(string s, int expected)
		{
			var res = _sut.LengthOfLongestSubstring(s);
			Assert.AreEqual(expected, res);
		}
	}
}