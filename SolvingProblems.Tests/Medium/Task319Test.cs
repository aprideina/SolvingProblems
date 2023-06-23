using NUnit.Framework;
using SolvingProblems.Medium;

namespace SolvingProblems.Tests.Medium
{
	public class Task319Test
	{
		[Theory]
		[TestCase(0, 0)]
		[TestCase(1, 1)]
		[TestCase(3, 1)]
		[TestCase(4, 2)]
		[TestCase(5, 2)]
		[TestCase(5, 2)]
		[TestCase(6, 2)]
		public void Test(int n, int result)
		{
			var _sut = new Task319();
			var res = _sut.BulbSwitch(n);
			Assert.AreEqual(result, res);
		}
	}
}
