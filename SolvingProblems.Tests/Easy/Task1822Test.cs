using NUnit.Framework;
using SolvingProblems.Easy;
using System.Collections.Generic;

namespace SolvingProblems.Tests.Easy
{
	public class Task1822Test
	{
		private static IEnumerable<object> GetSource()
		{
			yield return new object[]
			{
				new int[]{ -1,-2,-3,-4,3,2,1 },
				1
			};
			yield return new object[]
			{
				new int[]{ 1,5,0,2,-3 },
				0
			};
			yield return new object[]
			{
				new int[]{ -1,1,-1,1,-1 },
				-1
			};
		}

		[Theory]
		[TestCaseSource(nameof(GetSource))]
		public void Test(int[] nums, int result)
		{
			var sut = new Task1822();
			var r = sut.ArraySign(nums);
			Assert.AreEqual(result, r);
		}
	}
}
