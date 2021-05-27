using System;
using System.Collections.Generic;
using System.Linq;

namespace SolvingProblems.Trees
{
    public class ZigZagTree
    {
        private Func<double, bool> _isNormalSortOrderFunc = i => i % 2 != 0;

        private Func<double, double> _getMaxValueInLevel = i => Math.Pow(2, i) - 1;

        private Func<double, double> _getCountInLevel = level => Math.Pow(2, level - 1);

        private readonly Func<int, int> _getLevelByValue = i => (int)Math.Log(i, 2) + 1;

        public IList<int> PathInZigZagTree(int label)
        {
            var level = _getLevelByValue(label);
            var result = new Stack<int>(level);
            result.Push(label);

            var value = label;

            for (var i = (int)level; i > 1; i--)
            {
                var index = _getMaxValueInLevel(i) - value;
                var countInLevel = _isNormalSortOrderFunc(i) ? _getCountInLevel(i) - 1 - index : index;
                var parentIndex = (int)countInLevel / 2;

                value = Method(parentIndex, i - 1);
                result.Push(value);
            }

            return result.ToList();
        }

        private int Method(double index, double level)
        {
            if (level == 0)
            {
                return 1;
            }

            var leftValueInRow = _isNormalSortOrderFunc(level)
                ? _getMaxValueInLevel(level - 1) + 1 + index
                : _getMaxValueInLevel(level) - index;

            return (int)leftValueInRow;
        }
    }
}