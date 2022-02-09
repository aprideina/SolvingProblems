using NUnit.Framework;
using SolvingProblems.BinarySearch;

namespace SolvingProblems.Tests.BinarySearch
{
	public class BinarySearch704Test
	{
		private readonly BinarySearch704 _sut = new BinarySearch704();

		[Theory]
		[TestCase(new int[]{}, 9, -1)]
		[TestCase(new[] { 9 }, 9, 0)]
		[TestCase(new[] {-1, 0, 3, 5, 9, 12}, 3, 2)]
		[TestCase(new[] {-1, 0, 3, 5, 9, 12}, 5, 3)]
		[TestCase(new[] {-1, 0, 3, 5, 9, 12}, 9, 4)]
		[TestCase(new[] {-1, 0, 3, 5, 9, 12}, -1, 0)]
		[TestCase(new[] {-1, 0, 3, 5, 9, 12}, 12, 5)]
		[TestCase(new[] {-1, 0, 3, 5, 9, 12}, 9, 4)]
		[TestCase(new[] {-1, 0, 3, 5, 9, 12, 15}, 15, 6)]
		[TestCase(new[] {-1, 0, 3, 5, 9, 12, 15}, -1, 0)]
		[TestCase(new[] {-1, 0, 3, 5, 9, 12, 15}, 5, 3)]
		public void Test(int[] nums, int target, int result)
		{
			var index = _sut.Search(nums, target);
			Assert.AreEqual(index, result);
		}
	}
}