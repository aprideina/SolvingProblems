using System.Collections.Generic;
using NUnit.Framework;
using SolvingProblems.Graphs;

namespace SolvingProblems.Tests
{
    public class GraphServiceTest
    {
        [Test]
        public void Test()
        {
            var tree = new TreeNode(1)
            {
                Children = new List<TreeNode>
                {
                    new TreeNode(2)
                    {
                        Children = new List<TreeNode>
                        {
                            new TreeNode(4)
                            {
                                Children = new List<TreeNode>
                                {
                                    new TreeNode(6)
                                }
                            }
                        }
                    },
                    new TreeNode(3)
                    {
                        Children = new List<TreeNode>
                        {
                            new TreeNode(5)
                        }
                    }
                }
            };

            var graph = new GraphService();
            var result = graph.GetNodes(tree);

            var expected = new List<int> {1, 2, 3, 4, 5, 6}; 
            Assert.That(result, Is.EquivalentTo(expected));
        }
    }
}
