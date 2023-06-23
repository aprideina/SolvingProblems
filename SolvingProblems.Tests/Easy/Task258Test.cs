using NUnit.Framework;
using SolvingProblems.Easy;

namespace SolvingProblems.Tests.Easy
{
	class Task258Test
	{
		private Task258 _sut = new Task258();

		[Theory]
		[TestCase(38, 2)]
		[TestCase(111, 3)]
		[TestCase(19, 1)]
		[TestCase(199, 1)]
		[TestCase(0, 0)]
		public void Test(int num, int result)
		{
			var r = _sut.AddDigits(num);
			Assert.AreEqual(r, result);
		}
	}
}
