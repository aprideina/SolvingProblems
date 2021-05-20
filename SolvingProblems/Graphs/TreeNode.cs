using System.Collections.Generic;

namespace SolvingProblems.Graphs
{
    public class TreeNode
    {
        public IList<TreeNode> Children { get; set; }

        public int Value { get; }

        public TreeNode(int value)
        {
            Value = value;
            Children = new List<TreeNode>();
        }
    }
}
