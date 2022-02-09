using System.Collections.Generic;
using NUnit.Framework;
using SolvingProblems.Arrays;

namespace SolvingProblems.Tests.Arrays
{
	public class Array1351Test
	{
		private Array1351 _sut = new Array1351();

		private static object[] GetSource()
		{
			return new object[]{ new[,] { { 4, 3, 2, -1 }, { 3, 2, 1, -1 }, { 1, 1, -1, -2 }, { -1, -1, -2, -3 } }, 8  };
		}

		[Theory]
		[TestCaseSource(nameof(GetSource))]
		public void Test(int[,] matrix, int expected)
		{
			var result = _sut.CountNegatives(matrix);
			Assert.AreEqual(expected, result);
		}
	}
}