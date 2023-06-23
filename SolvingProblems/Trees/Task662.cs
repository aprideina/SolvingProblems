using System;
using System.Collections.Generic;
using System.Linq;

namespace SolvingProblems.Trees
{
	public class TreeNode
	{
		public int val;
		public TreeNode left;
		public TreeNode right;
		public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
		{
			this.val = val;
			this.left = left;
			this.right = right;
		}
	}

	public class Task662
	{
		public int WidthOfBinaryTree(TreeNode root)
		{
			var countNodes = new Dictionary<int, NodeInfo>();
			int maxLenght = 0;
			Down(root, countNodes, 1, ref maxLenght);

			return 0;
		}

		private void Down(TreeNode node, Dictionary<int, NodeInfo> countNodes, int lenght, ref int maxLenght)
		{
			if (countNodes.ContainsKey(lenght))
			{
				countNodes[lenght].Count++;
				countNodes[lenght].Index++;
			}
			else
			{
				countNodes[lenght] = new NodeInfo()
				{
					Count = 1
				};
				maxLenght++;
			}

			if (node.left == null && node.right == null)
			{
				return;
			}

			if (node.left != null)
			{
				Down(node.left, countNodes, lenght + 1, ref maxLenght);
			}

			if (node.right != null)
			{
				Down(node.right, countNodes, lenght + 1, ref maxLenght);
			}
		}

		//private void CalcNull(TreeNode node, Dictionary<int, NodeInfo> countNodes, int lenght, int maxLenght)
		//{
		//	if (node.left != null)
		//	{
		//		Down(node.left, countNodes, lenght + 1, ref maxLenght);
		//	}
		//	else
		//	{
		//		for (int i = lenght; i < maxLenght; i++)
		//		{
		//			var c = Math.Pow(2, i);
		//			countNodes[i] += (int)(c - 1);
		//		}
		//		if (countNodes.ContainsKey(lenght))
		//		{

		//		}
		//	}

		//	if (node.right != null)
		//	{
		//		Down(node.right, countNodes, lenght + 1, ref maxLenght);
		//	}
		//	else
		//	{
		//		var c = Math.Pow(2, maxLenght - lenght);
		//		if (countNodes.ContainsKey(lenght))
		//		{
		//			countNodes[lenght] += (int)(c - 1);
		//		}
		//	}
		//}

		private class NodeInfo
		{
			public int Level { get; set; }

			public int LeftIndex { get; set; }

			public int Rightindex { get; set; }

			public int Count { get; set; }

			public int Index { get; set; }
		}
	}
}
