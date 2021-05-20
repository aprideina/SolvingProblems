namespace SolvingProblems.Sorting
{
    /// <summary>
    /// https://leetcode.com/explore/interview/card/top-interview-questions-easy/96/sorting-and-searching/774/
    /// </summary>
    public class SortingService
    {
        public IBadVersionService _badVersionService;

        public SortingService(IBadVersionService badVersionService)
        {
            _badVersionService = badVersionService;
        }

        public int FirstBadVersion(int n)
        {
            var left = 1;
            var right = n;

            var result = n;

            while (left < right)
            {
                var diff = (right - left + 1) / 2;

                var middle = left + diff;

                var isBad = _badVersionService.IsBadVersion(middle);

                if (!isBad)
                {
                    left += diff;
                }
                else
                {
                    right -= diff;
                    result = middle;
                }
            }

            var isLeftBad = _badVersionService.IsBadVersion(left);

            return isLeftBad ? left : result;
        }
    }
}
