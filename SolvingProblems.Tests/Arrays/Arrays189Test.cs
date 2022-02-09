using NUnit.Framework;
using SolvingProblems.Arrays;

namespace SolvingProblems.Tests.Arrays
{
	public class Arrays189Test
	{
		private readonly Arrays189 _sut = new Arrays189();

		[Theory]
		[TestCase(new[] {1, 2, 3, 4, 5, 6, 7}, 3, new[] {5, 6, 7, 1, 2, 3, 4})]
		[TestCase(new[] {-1, -100, 3, 99}, 2, new[] {3, 99, -1, -100})]
		[TestCase(new[] {1, 2, 3, 4}, 2, new[] {3, 4, 1, 2})]
		[TestCase(new[] {1, 2}, 2, new[] {1, 2})]
		[TestCase(new[] {1, 2, 3}, 1, new[] {3, 1, 2})]
		//[TestCase(new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11}, 3, new[] { 5, 6, 7, 8, 9, 10, 11, 1, 2, 3, 4 })]
		[TestCase(new[] {1, 2, 3}, 2, new[] {2, 3, 1})]
		[TestCase(new[] {1, 2}, 1, new[] {2, 1})]
		[TestCase(new[] { 1, 2, 3, 4, 5, 6 }, 3, new[] {4, 5, 6, 1, 2, 3})]
		public void Test(int[] nums, int k, int[] expected)
		{
			_sut.Rotate(nums, k);
			Assert.AreEqual(expected, nums);
		}
	}
}