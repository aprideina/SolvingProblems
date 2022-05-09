using NUnit.Framework;
using SolvingProblems.Arrays;

namespace SolvingProblems.Tests.Arrays
{
	public class Array283Test
	{
		private Array283 _sut = new Array283();

		[Theory]
		[TestCase(new[] { 0, 1, 0, 3, 12 }, new[] { 1, 3, 12, 0, 0})]
		[TestCase(new[] { 0 }, new[] { 0})]
		[TestCase(new[] { 1,2,3,0 }, new[] { 1,2,3,0 })]
		[TestCase(new[] { 0,0,0,0 }, new[] { 0,0,0,0 })]
		[TestCase(new[] { 0,0,0,0,1 }, new[] { 1, 0,0,0,0 })]
		public void Test(int[] input, int[] expected)
		{
			_sut.MoveZeroes(input);

			Assert.AreEqual(expected, input);
		}
	}
}