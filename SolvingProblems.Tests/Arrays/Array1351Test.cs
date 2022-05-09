using System.Collections.Generic;
using NUnit.Framework;
using SolvingProblems.Arrays;

namespace SolvingProblems.Tests.Arrays
{
	public class Array1351Test
	{
		private readonly Array1351 _sut = new Array1351();

		private static IEnumerable<object> GetSource()
		{
			yield return new object[]
			{
				new[]
				{
					new[] {4, 3, 2, -1},
					new[] {3, 2, 1, -1},
					new[] {1, 1, -1, -2},
					new[] {-1, -1, -2, -3}
				},
				8
			};

			yield return new object[]
			{
				new[]
				{
					new[] {3,2},
					new[] {1,0}
				},
				0
			};
		}

		[Theory]
		[TestCaseSource(nameof(GetSource))]
		public void Test(int[][] matrix, int expected)
		{
			var result = _sut.CountNegatives(matrix);
			Assert.AreEqual(expected, result);
		}
	}
}