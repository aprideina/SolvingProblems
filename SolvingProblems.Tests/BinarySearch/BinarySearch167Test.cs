using NUnit.Framework;
using SolvingProblems.BinarySearch;

namespace SolvingProblems.Tests.BinarySearch
{
	public class BinarySearch167Test
	{
		private readonly BinarySearch167 _sut = new BinarySearch167();

		[Theory]
		[TestCase(new[] {2, 7, 11, 15}, 9, new[] {1, 2})]
		[TestCase(new[] {2, 3, 4}, 6, new[] {1, 3})]
		[TestCase(new[] {-1, 0}, -1, new[] {1, 2})]
		[TestCase(new[] { 5, 25, 75 }, 100, new[] {2, 3})]
		[TestCase(new[] { 5, 25, 30, 70, 71 }, 100, new[] {3, 4})]
		[TestCase(new[] { 1, 2, 3, 4, 4, 9, 56, 90 }, 8, new[] {4, 5})]
		public void Test(int[] input, int target, int[] expected)
		{
			var result = _sut.TwoSum(input, target);

			Assert.AreEqual(expected, result);
		}
	}
}