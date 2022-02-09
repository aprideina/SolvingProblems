using NUnit.Framework;
using SolvingProblems.BinarySearch;

namespace SolvingProblems.Tests.BinarySearch
{
	public class BinarySearch2089Test
	{
		private readonly BinarySearch2089 _sut = new BinarySearch2089();

		[Theory]
		[TestCase(new[] {1, 2, 5, 2, 3}, 2, new[] {1, 2})]
		[TestCase(new[] { 1, 2, 5, 2, 3 }, 3, new[] {3})]
		[TestCase(new[] { 1, 2, 5, 2, 3 }, 5, new[] {4})]
		public void Test(int[] nums, int target, int[] expected)
		{
			var result = _sut.TargetIndices(nums, target);
			Assert.AreEqual(expected, result);
		}
	}
}