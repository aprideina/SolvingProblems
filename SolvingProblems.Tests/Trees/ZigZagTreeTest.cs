using System.Collections.Generic;
using NUnit.Framework;
using SolvingProblems.Trees;

namespace SolvingProblems.Tests.Trees
{
    public class ZigZagTreeTest
    {
        [TestCase(14, new[]{ 1, 3, 4, 14 })]
        [TestCase(13, new[]{ 1, 3, 5, 13 })]
        [TestCase(11, new[]{ 1, 2, 6, 11 })]
        [TestCase(1, new[]{ 1 })]
        public void Test(int label, IList<int> result)
        {
            var sut = new ZigZagTree();
            Assert.That(sut.PathInZigZagTree(label), Is.EqualTo(result));
        }
    }
}