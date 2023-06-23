using NUnit.Framework;
using SolvingProblems.Medium;
using System.Collections.Generic;

namespace SolvingProblems.Tests.Medium
{
	public class Task54Test
	{
		private static IEnumerable<object> GetSource()
		{
			yield return new object[]
			{
				new int[][]
				{
					new int [] { 1,2,3 },
					new int [] { 4,5,6 },
					new int [] { 7,8,9 },
				},
				new int[] { 1, 2, 3, 6, 9, 8, 7, 4, 5 }
			};
			yield return new object[]
			{
				new int[][]
				{
					new int [] { 1,2,3,4 },
					new int [] { 5,6,7,8 },
					new int [] { 9,10,11,12 }
				},
				new int[] { 1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7 }
			};
		}

		[Theory, Ignore("Fix it")]
		[TestCaseSource(nameof(GetSource))]
		public void Test(int[][] nums, int[] result)
		{
			var sut = new Task54();
			var r = sut.SpiralOrder(nums);
			Assert.AreEqual(result, r);
		}
	}
}
