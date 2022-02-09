using NUnit.Framework;
using SolvingProblems.Pointers;

namespace SolvingProblems.Tests.Pointers
{
	public class Pointers977Test
	{
		private Pointers977 _sut = new Pointers977();

		[Theory]
		[TestCase(new []{-7, -3, 2, 3, 11}, new []{ 4, 9, 9, 49, 121 })]
		[TestCase(new []{ -4, -1, 0, 3, 10 }, new []{ 0, 1, 9, 16, 100 })]
		public void Test(int[] nums, int[] expected)
		{
			var result = _sut.SortedSquares(nums);

			Assert.AreEqual(expected, result);
		}
	}
}