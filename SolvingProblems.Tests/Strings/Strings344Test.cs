using NUnit.Framework;
using SolvingProblems.Sorting;

namespace SolvingProblems.Tests.Strings
{
	public class Strings344Test
	{
		private Strings344 _sut = new Strings344();

		[Theory]
		[TestCase(new[] { 'h', 'e', 'l', 'l', 'o' }, new[] { 'o', 'l', 'l', 'e', 'h' })]
		[TestCase(new[] { 'H', 'a', 'n', 'n', 'a', 'h' }, new[] { 'h', 'a', 'n', 'n', 'a', 'H' })]
		public void Test(char[] str, char[] expected)
		{
			_sut.ReverseString(str);

			Assert.AreEqual(expected, str);
		}
	}
}