namespace SolvingProblems.Medium
{
	/// <summary>
	/// https://leetcode.com/problems/smallest-number-in-infinite-set/
	/// </summary>
	public class Task2336
	{
        const int n = 1001;
        bool[] removedValues = new bool[n];
        int minimumIndex = 1;

        public Task2336()
        {
            removedValues = new bool[n];
            minimumIndex = 1;
        }

        public int PopSmallest()
        {
            var smallest = minimumIndex;
            removedValues[minimumIndex] = true;
            int nextMinimumIndex = minimumIndex;
            do
            {
                nextMinimumIndex++;
            }
            while (removedValues[nextMinimumIndex] != false);
            minimumIndex = nextMinimumIndex;
            return smallest;
        }

        public void AddBack(int num)
        {
            removedValues[num] = false;
            minimumIndex = num < minimumIndex ? num : minimumIndex;
        }
    }
}
