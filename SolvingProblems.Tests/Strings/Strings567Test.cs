using NUnit.Framework;
using SolvingProblems.Strings;

namespace SolvingProblems.Tests.Strings
{
	public class Strings567Test
	{
		public Strings567 _sut = new Strings567();

		[Theory, Ignore("Fix it")]
		[TestCase("ab", "eidbaooo", true)]
		[TestCase("ab", "eidboaoo", false)]
		[TestCase("adc", "dcda", true)]
		[TestCase("ab", "ab", true)]
		[TestCase("abc", "bbbca", true)]
		public void Test(string s1, string s2, bool result)
		{
			var checkInclusion = _sut.CheckInclusion(s1, s2);
			Assert.AreEqual(result, checkInclusion);
		}
	}
}