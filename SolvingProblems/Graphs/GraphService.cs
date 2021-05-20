using System.Collections.Generic;
using System.Linq;

namespace SolvingProblems.Graphs
{
    public class GraphService
    {
        public IEnumerable<int> GetNodes(TreeNode node)
        {
            var collection = new List<int>
            {
                node.Value
            };

            GetSubNodes(node.Children, collection);

            return collection;
        }

        public void GetSubNodes(IList<TreeNode> children, List<int> result)
        {
            result.AddRange(children.Select(x=>x.Value));

            var newRow = children.SelectMany(x => x.Children).ToList();

            if (newRow.Count > 0)
            {
                GetSubNodes(newRow, result);
            }
        }
    }
}
