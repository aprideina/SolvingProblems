using NUnit.Framework;
using SolvingProblems.Strings;

namespace SolvingProblems.Tests.Strings
{
	public class StringParentheses20Test
	{
		private StringParentheses20 _sut = new StringParentheses20();

		[Theory]
		[TestCase("()", true)]
		[TestCase("()[]{}", true)]
		[TestCase("(]", false)]
		[TestCase("(", false)]
		public void Test(string input, bool expected)
		{
			var result = _sut.IsValid(input);
			Assert.AreEqual(expected, result);
		}
	}
}