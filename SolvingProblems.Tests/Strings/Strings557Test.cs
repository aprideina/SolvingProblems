using NUnit.Framework;
using SolvingProblems.Sorting.SolvingProblems.Sorting;

namespace SolvingProblems.Tests.Strings
{
	internal class Strings557Test
	{
		private readonly Strings557 _sut = new Strings557();

		[Theory]
		[TestCase("Let's take LeetCode contest", "s'teL ekat edoCteeL tsetnoc")]
		[TestCase("God Ding", "doG gniD")]
		public void Test(string str, string expected)
		{
			var res = _sut.ReverseString(str);

			Assert.AreEqual(expected, res);
		}
	}
}