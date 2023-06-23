using NUnit.Framework;
using SolvingProblems.Trees;
using System.Collections.Generic;

namespace SolvingProblems.Tests.Trees
{
	public class Task662Test
	{
		private static IEnumerable<object> GetSource()
		{
			yield return new object[]
			{
				new TreeNode()
				{
					val = 1,
					left = new TreeNode()
					{
						val = 3,
						left = new TreeNode()
						{
							val = 5
						},
						right = new TreeNode()
						{
							val = 3
						}
					},
					right = new TreeNode()
					{
						val = 2,
						right = new TreeNode()
						{
							val = 9
						}
					}
				},
				4
			};
			yield return new object[]
			{
				new TreeNode()
				{
					val = 1,
					left = new TreeNode()
					{
						val = 3,
						left = new TreeNode()
						{
							val = 5,
							left = new TreeNode()
							{
								val = 6
							}
						}
					},
					right = new TreeNode()
					{
						val = 2,
						right = new TreeNode()
						{
							val = 9,
							left = new TreeNode()
							{
								val = 7
							}
						}
					}
				},
				7
			};
		}

		[Theory, Ignore("Fix it")]
		[TestCaseSource(nameof(GetSource))]
		public void Test(TreeNode node, int res)
        {
            var sut = new Task662();
			int result = sut.WidthOfBinaryTree(node);
			Assert.AreEqual(res, result);
        }
    }
}
