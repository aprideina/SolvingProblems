using NUnit.Framework;
using SolvingProblems.Easy;
using System.Collections.Generic;

namespace SolvingProblems.Tests.Easy
{
	public class Task1572Test
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
				25
			};
			yield return new object[]
			{
				new int[][]
				{
					new int [] { 1,1,1,1 },
					new int [] { 1,1,1,1 },
					new int [] { 1,1,1,1 },
					new int [] { 1,1,1,1 },
				},
				8
			};

			yield return new object[]
			{
				new int[][]
				{
					new int [] { 5 },
				},
				5
			};
		}

		[Theory]
		[TestCaseSource(nameof(GetSource))]
		public void Test(int[][] nums, double result)
		{
			var sut = new Task1572();
			var r = sut.DiagonalSum(nums);
			Assert.AreEqual(result, r);
		}
	}
}
