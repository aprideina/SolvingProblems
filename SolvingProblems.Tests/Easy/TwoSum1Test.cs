using System.Linq;
using NUnit.Framework;
using SolvingProblems.Easy;

namespace SolvingProblems.Tests.Easy
{
	public class TwoSum1Test
	{
		[Theory, Ignore("Fix it")]
		[TestCase(new [] { 2, 7, 11, 15}, 9, new [] { 0, 1 })]
		[TestCase(new [] { 3, 2, 4 }, 6, new [] { 1, 2 })]
		[TestCase(new [] { 3, 3 }, 9, new [] { 0, 1 })]
		public void Test(int[] nums, int target, int[] expected)
		{
			var service = new TwoSum1();
			var result = service.TwoSum(nums, target);
			
			Assert.True(expected.Contains(result[0]));
			Assert.True(expected.Contains(result[1]));
		}
	}
}
