using NUnit.Framework;
using SolvingProblems.Arrays;

namespace SolvingProblems.Tests.Arrays
{
	public class Array349Test
	{
		private readonly Array349 _sut = new Array349();

		[Theory]
		[TestCase(new[] {1, 2, 2, 1}, new[] {2, 2}, new []{ 2 })]
		[TestCase(new[] {1}, new[] {1}, new []{ 1 })]
		[TestCase(new[] { 4, 7, 9, 7, 6, 7 }, new[] { 5, 0, 0, 6, 1, 6, 2, 2, 4 }, new []{ 6, 4 })]
		public void Test(int[] nums1, int[] nums2, int[] expected)
		{
			var result = _sut.Intersection(nums1, nums2);
			Assert.AreEqual(expected, result);
		}
	}
}