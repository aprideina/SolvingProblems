using NUnit.Framework;
using SolvingProblems.Strings;

namespace SolvingProblems.Tests.Strings
{
    public class LongestSubstringTest
    {
        [TestCase("bbbbb", 1)]
        [TestCase("", 0)]
        [TestCase("pwwkew", 3)]
        [TestCase("abcabcbb", 3)]
        [TestCase("abcaabcd", 4)]
        [TestCase("abcadef", 6)]
        [TestCase("abca", 3)]
        [TestCase("aabc", 3)]
        [TestCase("aaabcaa", 3)]
        public void Test1(string text, int length)
        {
            var res = LongestSubstring.LengthOfLongestSubstring(text);
            Assert.That(res, Is.EqualTo(length));
        }
    }
}