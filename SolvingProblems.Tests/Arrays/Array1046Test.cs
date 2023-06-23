using System.Collections.Generic;
using NUnit.Framework;
using SolvingProblems.Arrays;

namespace SolvingProblems.Tests.Arrays
{
	public class Array1046Test
	{
		private readonly Array1046 _sut = new Array1046();
		private static IEnumerable<object> GetSource()
		{
			yield return new object[]
			{
				new int[]{2, 7, 4, 1, 8, 1 },
				1
			};
			yield return new object[]
			{
				new int[]{1},
				1
			};
			yield return new object[]
			{
				new int[]{1, 3},
				2
			};
			yield return new object[]
			{
				new int[]{2, 2},
				0
			};
			yield return new object[]
			{
				new int[]{3, 7, 2},
				2
			};
			yield return new object[]
			{
				new int[]{7,6,7,6,9},
				3
			};
			yield return new object[]
			{
				new int[]{9,3,2,10},
				0
			};
			yield return new object[]
			{
				new int[]{9,3,2,10},
				0
			};
			yield return new object[]
			{
				new int[]{4,3,4,3,2},
				2
			};
		}

		[Theory]
		[TestCaseSource(nameof(GetSource))]
		public void Test(int[] matrix, int expected)
		{
			var result = _sut.LastStoneWeight(matrix);
			Assert.AreEqual(expected, result);
		}
	}
}
