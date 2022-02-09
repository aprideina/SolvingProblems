using NUnit.Framework;
using SolvingProblems.BinarySearch;

namespace SolvingProblems.Tests.BinarySearch
{
	public class BinarySearch35Test
	{
		private BinarySearch35 _sut = new BinarySearch35();

		[Theory]
		[TestCase(new []{ 1, 3, 5, 6 }, 5, 2)]
		[TestCase(new []{ 1, 3, 5, 6 }, 2, 1)]
		[TestCase(new []{ 1, 3, 5, 6 }, 7, 4)]
		[TestCase(new []{ 2, 3, 5, 6, 9 }, 7, 4)]
		public void Test(int[] nums, int target, int result)
		{
			var index = _sut.SearchInsert(nums, target);
			Assert.True(index == result);
		}
	}
}